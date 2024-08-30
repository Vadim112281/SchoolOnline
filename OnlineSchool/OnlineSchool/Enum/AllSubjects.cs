using System.ComponentModel;

namespace OnlineSchool.Enum
{
    public enum AllSubjects
    {
        [Description("Українська мова")]
        UkrLanguage,

        [Description("Математика")]
        Math,

        [Description("Українська література")]
        UkrLiterature,

        [Description("Біологія")]
        Biology,

        [Description("Фізика")]
        Physics,

        [Description("Хімія")]
        Chemistry,

        [Description("Зарубіжна література")]
        WorldLiteratue,

        [Description("Історія України")]
        UkrHistory,

        [Description("Географія")]
        Geography
    }
}
