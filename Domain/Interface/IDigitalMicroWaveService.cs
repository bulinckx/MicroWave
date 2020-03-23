using Domain.Enumerator;
using Domain.Model;
using System;
using System.Collections.Generic;

namespace Domain.Interface
{
    public interface IDigitalMicroWaveService
    {
        DigitalMicroWave Initialize();
        IList<JobTemplate> GetTemplateByNameKind(String name, MealKind? kind);
        void Start(String inputString);
        String SerializeCurrentJobTemplateToJson();
        void ResetPotency(Decimal potency);
        void ResetTimeleft(DateTime timeleft);
        void SetJobTemplate(JobTemplate template);
        MicroWaveStatus GetStatus();
        String Cancel();
        DigitalMicroWave GetMicroWave();
        IList<JobTemplate> SaveTemplate(JobTemplate newTemplate);
        IList<JobTemplate> DeleteTemplate(JobTemplate template, MealKind? mealkind);
        void Pause();
        void Resume();

        void PersistTemplates();
    }
}