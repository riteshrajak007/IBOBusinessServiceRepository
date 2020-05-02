using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ILanguageService
    {
        IEnumerable<Language> GetAllLanguages();

        Language GetLanguage(int id);

        void AddLanguage(Language language);

        void UpdateLanguage(int id, Language language);

        void DeleteLanguage(Language language);
    }
}
