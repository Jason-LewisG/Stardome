﻿using System;
using System.Collections.Generic;
using Stardome.DomainObjects;
using Stardome.Repositories;

namespace Stardome.Services.Domain
{
    public class SiteSettingsService : ISiteSettingsService
    {
        private readonly ISiteSettingsRepository repository;
        public SiteSettingsService(ISiteSettingsRepository aRepository)
        {
            repository = aRepository;
        }

        public SiteSetting GetById(int aSiteSettingId)
        {
            return repository.GetById(aSiteSettingId);
        }

        public String GetSiteName
        {
            get{return repository.GetById(1).Value;}
        }

        public String GetFilePath
        {
            get{return repository.GetById(2).Value;}
        }
   
        public IEnumerable<SiteSetting> GetAll()
        {
            return repository.GetAll();
        }


        public String UpdateSiteSettings(List<SiteSetting> lstSiteSettings)
        {
            return repository.UpdateSiteSettings(lstSiteSettings);
           
        }
    }
}