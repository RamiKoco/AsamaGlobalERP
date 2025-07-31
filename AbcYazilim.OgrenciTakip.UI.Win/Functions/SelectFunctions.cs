﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Dto.KisiDto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Kisi;
using AbcYazilim.OgrenciTakip.Model.Entities.KitapTuru;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.AdresTurleriForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.AvukatForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaHesapForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BankaSubeForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.DepartmanForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.EtiketForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.GorevForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlceForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IsyeriForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KasaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KayitKaynakForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KimlikTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiGrubuForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KitapTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KontenjanForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KullaniciForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KurguForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.KurumTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.MahalleForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.MeslekForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.OdemeTuruForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.OzelKodForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.PozisyonForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.RehberForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.RenkForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SinifForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SosyalMedyaForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.SubeForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.TesvikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.UlkeForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.UyrukForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YabancıDilForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using System;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Variables
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private MyButtonEdit _objEdit;
        private KartTuru _kartTuru;
        private OdemeTipi _odemeTipi;
        private BankaHesapTuru _hesapTuru;

        #endregion

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, OdemeTipi odemeTipi)
        {
            _btnEdit = btnEdit;
            _odemeTipi = odemeTipi;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru, BankaHesapTuru hesapTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            _hesapTuru = hesapTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit, MyButtonEdit objEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            _objEdit = objEdit;
            SecimYap();
        }
        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtUlke":
                    {
                        var entity = (Ulke)ShowListForms<UlkeListForm>.ShowDialogListForm(KartTuru.Ulke,
                            _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.UlkeAdi;
                        }
                    }
                    break;

                case "txtIl":
                case "txtAdresIl":
                case "txtEvAdresIl":
                case "txtIsAdresIl":
                case "txtKimlikIl":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "txtIlce":
                case "txtAdresIlce":
                case "txtEvAdresIlce":
                case "txtIsAdresIlce":
                case "txtKimlikIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id,
                            _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;

                case "txtMahalle":
                    {
                        var entity = (Mahalle)ShowListForms<MahalleListForm>.ShowDialogListForm(KartTuru.Mahalle,
                            _btnEdit.Id,
                            _prmEdit.Id,
                            _objEdit.Id,
                            _objEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MahalleAdi;
                        }
                    }
                    break;


                case "txtGrup":
                    {
                        var entity =
                            (SinifGrup)ShowListForms<SinifGrupListForm>.ShowDialogListForm(KartTuru.SinifGrup,
                                _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupAdi;
                        }
                    }
                    break;

                case "txtHizmetTuru":
                    {
                        var entity =
                            (HizmetTuru)ShowListForms<HizmetTuruListForm>.ShowDialogListForm(KartTuru.HizmetTuru,
                                _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HizmetTuruAdi;
                        }
                    }
                    break;

                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod,
                            _btnEdit.Id, OzelKodTuru.OzelKod1, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod,
                            _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod,
                            _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod,
                            _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;

                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod,
                            _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;


                case "txtBanka":
                    {
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankaAdi;
                        }
                    }
                    break;

                case "txtBankaSube":
                    {
                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;

                case "txtMeslek":
                    {
                        var entity = (Meslek)ShowListForms<MeslekListForm>.ShowDialogListForm(KartTuru.Meslek, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MeslekAdi;
                        }
                    }
                    break;


                case "txtKayitKaynak":
                    {
                        var entity = (KayitKaynak)ShowListForms<KayitKaynakListForm>.ShowDialogListForm(KartTuru.KayitKaynak, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KayitKaynakAdi;
                        }
                    }
                    break;

                case "txtEtiket":
                    {
                        var entity = (EtiketL)ShowListForms<EtiketListForm>.ShowDialogListForm(KartTuru.Etiket, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.EtiketAdi;
                        }
                    }
                    break;

                case "txtRenk":
                    {
                        var entity = (RenkL)ShowListForms<RenkListForm>.ShowDialogListForm(KartTuru.Renk, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.RenkAdi;
                        }
                    }
                    break;

                case "txtKisiGrubu":
                    {
                        var entity = (KisiGrubu)ShowListForms<KisiGrubuListForm>.ShowDialogListForm(KartTuru.KisiGrubu, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupAdi;
                        }
                    }
                    break;

                case "txtAdresTurleri":
                    {
                        var entity = (AdresTurleriL)ShowListForms<AdresTurleriListForm>.ShowDialogListForm(KartTuru.AdresTurleri, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;


                case "txtIsyeri":
                    {
                        var entity = (Isyeri)ShowListForms<IsyeriListForm>.ShowDialogListForm(KartTuru.Isyeri, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsyeriAdi;
                        }
                    }
                    break;


                case "txtGorev":
                    {
                        var entity = (Gorev)ShowListForms<GorevListForm>.ShowDialogListForm(KartTuru.Gorev, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GorevAdi;
                        }
                    }
                    break;

                case "txtIndirimTuru":
                    {
                        var entity = (IndirimTuru)ShowListForms<IndirimTuruListForm>.ShowDialogListForm(KartTuru.IndirimTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IndirimTuruAdi;
                        }
                    }
                    break;

                case "txtSinif":
                    {
                        var entity = (SinifL)ShowListForms<SinifListForm>.ShowDialogListForm(KartTuru.Sinif, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SinifAdi;
                        }
                    }
                    break;
                case "txtDepartman":
                    {
                        var entity = (Departman)ShowListForms<DepartmanListForm>.ShowDialogListForm(KartTuru.Departman, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;
                case "txtPozisyon":
                    {
                        var entity = (PozisyonL)ShowListForms<PozisyonListForm>.ShowDialogListForm(KartTuru.Pozisyon, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;
                case "txtUyruk":
                    {
                        var entity = (UyrukL)ShowListForms<UyrukListForm>.ShowDialogListForm(KartTuru.Uyruk, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;
                case "txtKimlikTuru":
                    {
                        var entity = (KimlikTuruL)ShowListForms<KimlikTuruListForm>.ShowDialogListForm(KartTuru.KimlikTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KimlikAdi;
                        }
                    }
                    break;

                case "txtSorumlu":
                    {
                        var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;
                case "txtKurumTuru":
                    {
                        var entity = (KurumTuruL)ShowListForms<KurumTuruListForm>.ShowDialogListForm(KartTuru.KurumTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;

                case "txtYabanciDil":
                    {
                        var entity = (YabanciDil)ShowListForms<YabanciDilListForm>.ShowDialogListForm(KartTuru.YabanciDil, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DilAdi;
                        }
                    }
                    break;

                case "txtGeldigiOkul":
                    {
                        var entity = (OkulL)ShowListForms<OkulListForm>.ShowDialogListForm(KartTuru.Okul, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OkulAdi;
                        }
                    }
                    break;

                case "txtKontenjan":
                    {
                        var entity = (Kontenjan)ShowListForms<KontenjanListForm>.ShowDialogListForm(KartTuru.Kontenjan, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KontenjanAdi;
                        }
                    }
                    break;

                case "txtTesvik":
                    {
                        var entity = (Tesvik)ShowListForms<TesvikListForm>.ShowDialogListForm(KartTuru.Tesvik, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.TesvikAdi;
                        }
                    }
                    break;

                case "txtRehber":
                    {
                        var entity = (Rehber)ShowListForms<RehberListForm>.ShowDialogListForm(KartTuru.Rehber, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                    }
                    break;

                case "txtBankaHesap":
                case "txtDefaultBankaHesap":
                    {
                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _odemeTipi);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.BlokeGunSayisi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HesapAdi;
                        }
                    }
                    break;

                case "txtOdemeTuru":
                    {
                        var entity = (OdemeTuru)ShowListForms<OdemeTuruListForm>.ShowDialogListForm(KartTuru.OdemeTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.OdemeTipi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OdemeTuruAdi;
                        }
                    }
                    break;

                case "txtDefaultAvukatHesap":
                    {
                        var entity = (AvukatL)ShowListForms<AvukatListForm>.ShowDialogListForm(KartTuru.Avukat, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                    }
                    break;

                case "txtDefaultKasaHesap":
                    {
                        var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KasaAdi;
                        }
                    }
                    break;

                case "txtSube":
                    {
                        var entity = (SubeL)ShowListForms<SubeListForm>.ShowDialogListForm(KartTuru.Sube, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;

                case "txtRol":
                    {
                        var entity = (Rol)ShowListForms<RolListForm>.ShowDialogListForm(KartTuru.Rol, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.RolAdi;
                        }
                    }
                    break;



                case "txtHesap":
                    {
                        switch (_kartTuru)
                        {
                            case KartTuru.Avukat:
                                {
                                    var entity = (AvukatL)ShowListForms<AvukatListForm>.ShowDialogListForm(KartTuru.Avukat, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.AdiSoyadi;
                                    }
                                    break;
                                }
                            case KartTuru.Kasa:
                                {
                                    var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.KasaAdi;
                                    }
                                    break;
                                }
                            case KartTuru.BankaHesap:
                                {
                                    var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _hesapTuru);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.HesapAdi;
                                    }
                                    break;
                                }

                            case KartTuru.Cari:
                                {
                                    var entity = (CariL)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.CariAdi;
                                    }
                                    break;
                                }

                            case KartTuru.Sube:
                                {
                                    var entity = (SubeL)ShowListForms<SubeListForm>.ShowDialogListForm(KartTuru.Sube, _btnEdit.Id, true);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.SubeAdi;
                                    }
                                    break;
                                }

                        }
                    }
                    break;

                case "txtKurgu":
                    {
                        var entity = (Kurgu)ShowListForms<KurguListForm>.ShowDialogListForm(KartTuru.Kurgu, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KurguAdi;
                        }
                    }
                    break;

                case "txtKitapTuru":
                    {
                        var entity = (KitapTuru)ShowListForms<KitapTuruListForm>.ShowDialogListForm(KartTuru.KitapTuru, _btnEdit.Id,
                            _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KitapTuruAdi;
                        }
                    }
                    break;

                case "txtSosyalMedyaPlatformu":
                    {
                        var entity = (SosyalMedyaPlatformuL)ShowListForms<SosyalMedyaPlatformuListForm>.ShowDialogListForm(KartTuru.SosyalMedyaPlatformu,
                            _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Ad;
                        }
                    }
                    break;

                case "txtKayitHesabi":
                    {                     

                        if (_kartTuru == KartTuru.Kisi)
                        {
                            var entity = (KisiL)ShowListForms<KisiListForm>.ShowDialogListForm(KartTuru.Kisi, _btnEdit.Id);
                            if (entity != null)
                            {
                                _btnEdit.Id = entity.Id;
                                _btnEdit.EditValue = entity.Ad ;
                            }
                        }
                        else if (_kartTuru == KartTuru.Personel)
                        {
                            var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, _btnEdit.Id);
                            if (entity != null)
                            {
                                _btnEdit.Id = entity.Id;
                                _btnEdit.EditValue = entity.Ad;
                            }
                        }
                        else if (_kartTuru == KartTuru.Meslek)
                        {
                            var entity = (Meslek)ShowListForms<MeslekListForm>.ShowDialogListForm(KartTuru.Meslek, _btnEdit.Id);
                            if (entity != null)
                            {
                                _btnEdit.Id = entity.Id;
                                _btnEdit.EditValue = entity.MeslekAdi;
                            }
                        }
                        // diğer türler...
                    }
                    break;


            }

           
        }

     
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
       
    }
}

