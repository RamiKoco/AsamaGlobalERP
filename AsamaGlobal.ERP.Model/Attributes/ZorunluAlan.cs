﻿using System;

namespace AsamaGlobal.ERP.Model.Attributes
{
    public class ZorunluAlan : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Doğrulama(Validation) İşlemleri Sırasında Zorunlu Olan Alanları İşaretlemek İçin Kullanılacak.
        /// </summary>
        /// <param name="description"> Uyarı Mesajında Gösterilecek Olan Açıklama </param>
        /// <param name="controlName"> Uyarı Mesajı Sonrası Focuslanılacak Control Adı </param>
        public ZorunluAlan(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
