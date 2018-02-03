using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Post.WebAppAdmin
{
    public static class Messages
    {
        public enum MessagesEnum
        {
            [Display(Name = "Электронный адрес не должен быть пустым")] EmptyEmail,
            [Display(Name = "Электронный адрес должен быть уникальным")] UniqueEmail,
            [Display(Name = "ФИО не должно быть пустым")] EmptyName,
            [Display(Name = "Пароль не должен быть пустым")] EmptyPassword,
            [Display(Name = "Введенные данные не являются верными для администратора")] NoRights
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }
}