using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        #region Company
        /* Company  is Messages */
        public static string CompanyAdded = "Şirket Bilgileri Eklendi";
        public static string CompanyDeleted = "Şirket Bilgileri Silindi";
        public static string CompanyUpdated = "Şirket Bilgileri Güncellendi";
        public static string CompanyListed = "Tüm Şirketler Listelendi";
        #endregion

        #region Contract
        public static string ContractAdded = "Sözleşme Eklendi";
        public static string ContractDeleted = "Sözleşme Silindi";
        public static string ContractUpdated = "Sözleşme Güncellendi";
        public static string ContractListed = "Sözleşmeler Listelendi";

        #endregion

        #region Document
        public static string DocumentAdded = "Döküman Eklendi";
        public static string DocumentUpdated = "Döküman Güncellendi";
        public static string DocumentDeleted = "Döküman Silindi";
        public static string DocumentListed = "Dökümanlar Listelendi";
        public static string CompanyNameAlreadyExists="Şirket Adı Zaten Mevcut";
        public static string CompanyShortNameAlreadyExists="Şirket Kısa Adı Zaten Mevcut";
        #endregion

        internal static string UserAdded="Kullanıcı Eklendi";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
