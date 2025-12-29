using System;
using System.Collections.Generic;
using System.Text;
using ExamSchedule.Model;

namespace ExamSchedule.Data
{
    public static class DataSection
    {
        private static List<Section> Sections = [];

        static DataSection()
        {
            Sections.Add(new Section { Id = 1, Name = "LPU_S1" });
            Sections.Add(new Section { Id = 2, Name = "LPU_S2" });
            Sections.Add(new Section { Id = 3, Name = "LPU_S3" });
            Sections.Add(new Section { Id = 4, Name = "LPU_S4" });
            Sections.Add(new Section { Id = 5, Name = "LPU_S5" });
        }

        public static List<Section> GetSections()
        {
            return Sections;
        }
    }
}