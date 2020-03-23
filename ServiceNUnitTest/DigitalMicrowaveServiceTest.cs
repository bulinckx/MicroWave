using Domain.Enumerator;
using Domain.Interface;
using Domain.Model;
using NUnit.Framework;
using Repository;
using Service;
using System;
using System.Linq;
using System.Text.Json;

namespace ServiceNUnitTest
{
    [TestFixture]
    public class DigitalMicrowaveServiceTest
    {
        private IDigitalMicroWaveRepository _repo;
        private IDigitalMicroWaveService _service;

        [OneTimeSetUp]
        public void Setup()
        {
            _repo = new DigitalMicroWaveRepository();
            _service = new DigitalMicroWaveService(_repo);

            _service.Initialize();
        }

        #region Templates

        private JobTemplate GetNewTemplate()
        {
            return new JobTemplate(120, Domain.Enumerator.Potency.Ten)
            {
                Name = "1234567",
                MealKind = Domain.Enumerator.MealKind.Meat
            };
        }

        [Test]
        public void TestReturnFiveDefault()
        {
            var testTtemplate = _service.GetTemplateByNameKind(String.Empty, null).Where(t => t.CanDelete == false);
            Assert.AreEqual(5, testTtemplate.Count());
        }

        [Test]
        public void TestAddCustomTemplate()
        {
            JobTemplate newTemplate = GetNewTemplate();

            _service.SaveTemplate(newTemplate);
            var actual = _service.GetTemplateByNameKind(newTemplate.Name, newTemplate.MealKind).First();

            Assert.AreEqual(newTemplate, actual);
        }

        [Test]
        public void TestFailToDeletePremadeTemplate()
        {
            var testTtemplate = _service.GetTemplateByNameKind(String.Empty, null);
            var item = testTtemplate.First(t => t.CanDelete == false);

            var ex = Assert.Throws<Exception>(() => _service.DeleteTemplate(item, null));
            Assert.That(ex.Message, Is.EqualTo("Cannot delete a pre-made template."));
        }

        [Test]
        public void TestPersitTempaltes()
        {
            try
            {
                _service.PersistTemplates();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        #endregion Templates

        #region JobStatus

        private String GetInputString()
        {
            return @"{
  ""Name"": ""New Job"",
  ""MealKind"": null,
  ""Dot"": ""."",
  ""Instructions"": null,
  ""CanDelete"": true,
  ""Default"": false,
  ""Id"": ""1bbfac76-5a78-4687-b3d5-528d382d39a5"",
  ""Potency"": 8,
  ""TimeLeft"": 120
}";
        }

        [Test]
        public void TestStartPauseResumeCancelJob()
        {
            _service.Start(GetInputString());
            Assert.AreEqual(MicroWaveStatus.Running, _service.GetStatus());

            _service.Pause();
            Assert.AreEqual(MicroWaveStatus.DoorOpen, _service.GetStatus());

            _service.Resume();
            Assert.AreEqual(MicroWaveStatus.Running, _service.GetStatus());

            _service.Cancel();
            Assert.AreEqual(MicroWaveStatus.JobLess, _service.GetStatus());
        }

        [Test]
        public void TestJobTemplate()
        {
            JobTemplate newTemplate = GetNewTemplate();

            _service.SetJobTemplate(newTemplate);
            var expected = _service.SerializeCurrentJobTemplateToJson();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var actual = JsonSerializer.Serialize(_service.GetMicroWave().CurrentJob.Template, options);

            Assert.AreEqual(expected, actual);
        }

        #endregion JobStatus

        [Test]
        public void TestResetPotency()
        {
            JobTemplate newTemplate = GetNewTemplate();
            _service.Cancel();
            _service.SetJobTemplate(newTemplate);
            Assert.AreEqual(Potency.Eight, _service.GetMicroWave().Potency);

            _service.ResetPotency(10);
            Assert.AreEqual(Potency.Ten, _service.GetMicroWave().CurrentJob.Potency);
        }

        [Test]
        public void TestResetTimleft()
        {
            JobTemplate newTemplate = GetNewTemplate();
            _service.Cancel();
            _service.SetJobTemplate(newTemplate);
            Assert.AreEqual(30, _service.GetMicroWave().TimeLeft);

            _service.ResetTimeleft(DateTime.MinValue.AddSeconds(1));
            Assert.AreEqual(1, _service.GetMicroWave().CurrentJob.TimeLeft);
        }

        [Test]
        public void TestFailResetPotency()
        {
            JobTemplate newTemplate = GetNewTemplate();
            _service.Cancel();
            _service.SetJobTemplate(newTemplate);
            Assert.AreEqual(Potency.Eight, _service.GetMicroWave().Potency);

            var ex1 = Assert.Throws<Exception>(() => _service.ResetPotency(11));
            Assert.That(ex1.Message, Is.EqualTo("A potência máxima é Dez."));

            var ex2 = Assert.Throws<Exception>(() => _service.ResetPotency(0));
            Assert.That(ex2.Message, Is.EqualTo("Por favor informe uma potência entre Um e Dez.."));
        }

        [Test]
        public void TestFailResetTimeleft()
        {
            JobTemplate newTemplate = GetNewTemplate();
            _service.Cancel();
            _service.SetJobTemplate(newTemplate);
            Assert.AreEqual(30, _service.GetMicroWave().TimeLeft);

            var ex1 = Assert.Throws<Exception>(() => _service.ResetTimeleft(DateTime.MinValue));
            Assert.That(ex1.Message, Is.EqualTo("Por favor informe um tempo entre um segundo e dois minutos."));

            var ex2 = Assert.Throws<Exception>(() => _service.ResetTimeleft(DateTime.MinValue.AddSeconds(121)));
            Assert.That(ex2.Message, Is.EqualTo("O tempo de aquecimento não pode ser superior a dois minutos."));
        }
    }
}