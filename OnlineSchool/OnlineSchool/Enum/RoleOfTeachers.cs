using System.ComponentModel;

namespace OnlineSchool.Enum
{
    public enum RoleOfTeachers
    {
        [Description("Вчитель")]
        Teacher,

        [Description("Завуч")]
        HeadTeacher,

        [Description("Директор")]
        HeadMaster
    }
}
