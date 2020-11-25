using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleteded = "Ürün başarıyla silindi";
        public static string ProductUpdateded = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";

        public static string SuccessfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
    }
}
