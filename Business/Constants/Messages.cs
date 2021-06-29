using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string AddedUser = "Kayıt işlemi başarılı";

        public static string DeletedUser = "Kayıt başarı ile silindi";

        public static string UpdatedRegister = "Bilgiler Güncellendi";
        public static string deneme = "kullanıcı getirildi";

        public static string UpdatedUser = "Kullanıcı bilgileri başarıyla düzenlendi";

        public static string AuthorizationDenied = "Yetkiniz olmayan işlem";

        public static string UserExists = "Böyle bir kullanıcı sistemde kayıtlı";

        public static string BadPassword = "Daha iyi bir şifre deneyiniz";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string AddedWork = "İlan başarıyla eklendi";

        public static string DeletedWork = "ilan başarıyla silindi";

        public static string UpdatedWork = "İlan başarıyla güncellendi";

        public static string WorksListed = "İlanlar başarıla listelendi";

        public static string AddedWorkReference = "Başvurunuz tamamlandı";

        public static string DeletedWorkReference = "Başvurunuz silindi";

        public static string UpdatedWorkReference = "Başvurunuz güncellendi";
    }
}
