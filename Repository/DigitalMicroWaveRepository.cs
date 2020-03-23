using Domain.Enumerator;
using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Repository
{
    public class DigitalMicroWaveRepository : IDigitalMicroWaveRepository
    {
        public IList<JobTemplate> LoadDefaultTemplates()
        {
            IList<JobTemplate> templates = new List<JobTemplate>();

            templates.Add(new JobTemplate(120, Potency.Ten)
            {
                Default = true,
                CanDelete = false,
                Name = "Chicken",
                MealKind = MealKind.Chicken,
                Dot = '$',
                Instructions = "Instructions for defrost Chicken."
            });

            templates.Add(new JobTemplate(100, Potency.Ten)
            {
                Default = false,
                CanDelete = false,
                Name = "Popcorn",
                MealKind = null,
                Dot = '*',
                Instructions = "Instructions for Popcorn."
            });

            templates.Add(new JobTemplate(1, Potency.One)
            {
                Default = false,
                CanDelete = false,
                Name = "Minimal meal",
                MealKind = null,
                Dot = '`',
                Instructions = "Instructions for cooking a minimal meal."
            });

            templates.Add(new JobTemplate(30, Potency.Four)
            {
                Default = false,
                CanDelete = false,
                Name = "Nursing bottle",
                MealKind = null,
                Dot = '&',
                Instructions = "Instructions for a slight hot nursing bottle."
            });

            templates.Add(new JobTemplate(60, Potency.Five)
            {
                Default = false,
                CanDelete = false,
                Name = "Cheese",
                MealKind = MealKind.Cheese,
                Dot = '@',
                Instructions = "Instructions for five cheese surprise."
            });

            return templates;
        }

        public async void SaveTemplatesToFile(String fullpath, IList<JobTemplate> templates)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            String jsonString = JsonSerializer.Serialize(templates, options);
            using (FileStream fs = File.Create(fullpath))
            {
                await JsonSerializer.SerializeAsync(fs, templates);
            }
        }

        public IList<JobTemplate> ReadTemplatesFromFile(String fullpath)
        {
            if (File.Exists(fullpath))
            {
                IList<JobTemplateParameterLess> templates = JsonSerializer.Deserialize<IList<JobTemplateParameterLess>>(File.ReadAllText(fullpath));
                return templates.Select(t => t.Get()).ToList();
            }
            else return LoadDefaultTemplates();
        }

        public String GetCurrentPath(String fileName)
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + fileName;
        }

        public Boolean TryGetFullPath(String path, out String result)
        {
            result = String.Empty;
            if (String.IsNullOrWhiteSpace(path))
                return false;

            Boolean status = false;

            try
            {
                result = Path.GetFullPath(path);
                status = true;
            }
            catch (ArgumentException) { }
            catch (SecurityException) { }
            catch (NotSupportedException) { }
            catch (PathTooLongException) { }

            return status;
        }

        public String ReadTextFile(String fullpath)
        {
            if (File.Exists(fullpath))
            {
                return File.ReadAllText(fullpath);
            }
            else
                throw new Exception($"Cannot find file:{fullpath}");
        }
    }
}