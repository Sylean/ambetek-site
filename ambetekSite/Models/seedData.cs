using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ambetekSite.Models
{
    public static class seedData
    {
        public static void Initialize(IServiceProvider isp)
        {
            using (var context = new labTestContext(
                isp.GetRequiredService<DbContextOptions<labTestContext>>()))
            {
                if (context.labTest.Any())
                {
                    return;
                }

                context.labTest.AddRange(
                    new labTest
                    {
                        testCode = "34392X",
                        Description = "Electrolyte Panel",
                        Price = 5.25M,
                        Category = testCategory.Panels
                    },
new labTest
{
    testCode = "10256X",
    Description = "Hepatic Function Panel",
    Price = 5.50M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10165X",
    Description = "Basic Metabolic Panel w/eGFR",
    Price = 5.75M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10231X",
    Description = "Comprehensive Metabolic Panel w/eGFR",
    Price = 8.75M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "7600X",
    Description = "Lipid Panel",
    Price = 12.5M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "14852X",
    Description = "Lipid Panel w/Reflex to Direct LDL",
    Price = 12.5M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "20210X",
    Description = "Obstetric Panel w/Reflex",
    Price = 172.50M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10306X",
    Description = "Hepatitis Panel, Acute w/Reflex",
    Price = 240.00M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10715X",
    Description = "Food Allergy Profile, Adult",
    Price = 199.50M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10659X",
    Description = "Childhood Allergy (Food-Environ)",
    Price = 249.00M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "10644X",
    Description = "Upper Respiratory Allergy, Region II",
    Price = 287.00M,
    Category = testCategory.Panels
},
new labTest
{
    testCode = "809X",
    Description = "ESR",
    Price = 13.00M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "510X",
    Description = "Hemoglobin",
    Price = 4.00M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "509X",
    Description = "Hematocrit",
    Price = 4.00M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "1759X",
    Description = "CBC (Hgb, Hct, RBC, WBC, Pit)",
    Price = 4.25M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "6399X",
    Description = "CBC w/Diff (Hgb, Hct, RBC, WBC, Pit, Diff)",
    Price = 4.75M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "8847X",
    Description = "PT w/ INR",
    Price = 4.75M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "763X",
    Description = "PTT (Activated)",
    Price = 5.50M,
    Category = testCategory.Hematology
},
new labTest
{
    testCode = "7788X",
    Description = "ABO Group & Rh Type",
    Price = 24.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "223X",
    Description = "Albumin",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "234X",
    Description = "Alk Phosphatase",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "823X",
    Description = "ALT",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "243X",
    Description = "Amylase, Serum",
    Price = 13.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "249X",
    Description = "ANAchoice w/ reflex",
    Price = 30.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "795X",
    Description = "Antibody Screen, RBC w/reflex ID and Titer",
    Price = 25.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "822X",
    Description = "AST",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "285X",
    Description = "Bilirubin, Direct",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "287X",
    Description = "Bilirubin, Total",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "303X",
    Description = "Calcium",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "310X",
    Description = "Carbon Dioxide",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "10124X",
    Description = "Cardio CRP",
    Price = 13.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "978X",
    Description = " CEA",
    Price = 46.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "330X",
    Description = "Chloride",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "334X",
    Description = "Cholesterol",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "374X",
    Description = "CK, total",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4420X",
    Description = "C-Reactive Protein",
    Price = 20.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "7943X",
    Description = "Creatinine Clearance w/eGFR",
    Price = 45.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "375X",
    Description = "Creatinine w/eGFR",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "11173X",
    Description = "Cyclic Citrulline Peptide (IgG)",
    Price = 49.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "457X",
    Description = "Ferritin",
    Price = 20.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "466X",
    Description = "Folate",
    Price = 17.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "470X",
    Description = "FSH",
    Price = 8.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "483X",
    Description = "Glucose",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "484X",
    Description = "Glucose, Fasting",
    Price = 17.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8477X",
    Description = "Glucose, Gest Screen (50G)",
    Price = 17.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "34838X",
    Description = "H. pylori Ag, QL, Stool",
    Price = 58.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "14839X",
    Description = "H. pylori Urea Breath",
    Price = 90.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "512X",
    Description = "HAV Ab (IgM)",
    Price = 20.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4848X",
    Description = "HB Core Ab (IgM)",
    Price = 20.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8475X",
    Description = "HBs Ab",
    Price = 53.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "498X",
    Description = "HBs Ag w/Reflex",
    Price = 20.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8435X",
    Description = "hCG, Qual, Serum",
    Price = 10.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8396X",
    Description = "hCG Serum",
    Price = 17.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8472X",
    Description = "hCV Ab",
    Price = 20.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "608X",
    Description = "HDL Cholesterol",
    Price = 4.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "496X",
    Description = "Hemoglobin A1C",
    Price = 13.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "35489X",
    Description = "Hemoglobinopathy Evaluation",
    Price = 57.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "19728X",
    Description = "HIV-1 Antibody w/Reflex",
    Price = 25.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "31789X",
    Description = "Homocystein, Cardiovascular",
    Price = 87.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "3636X",
    Description = "HSV 1 lgG, HerpeSelect",
    Price = 47.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "6447X",
    Description = "HSV 1 & 2, lgG, HerpeSelect",
    Price = 94.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "3640X",
    Description = "HSV 2 lgG, HerpeSelect",
    Price = 47.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "571X",
    Description = "Iron",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "7573X",
    Description = "Iron and TIBC",
    Price = 20.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8293X",
    Description = "LDL Cholesterol, Direct",
    Price = 36.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "599X",
    Description = "Lead, Blood",
    Price = 35.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "615X",
    Description = "LH",
    Price = 8.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "606X",
    Description = "Lipase, Serum",
    Price = 31.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8593X",
    Description = "Lyme Disease (IgG, IgM) WB",
    Price = 145.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "6646X",
    Description = "Lyme Disease, EIA w/Reflex WB",
    Price = 70.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "622X",
    Description = "Magnesium",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "6517X",
    Description = "Microalbumin, Random Urine w/creatinine",
    Price = 20.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4555X",
    Description = "Microalbumin, 24 Hour Urine, w/o creatinine",
    Price = 25.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "11290X",
    Description = "Occult Blood, Stool, FIT, InSure",
    Price = 77.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "733X",
    Description = "Potassium",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "745X",
    Description = "Progesterone",
    Price = 33.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "746X",
    Description = "Prolactin",
    Price = 20.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "747X",
    Description = "Protein, Electr. w/TPROT, SERU",
    Price = 42.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "754X",
    Description = "Protein, Total",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "5363X",
    Description = "PSA, Total",
    Price = 20.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "8837X",
    Description = "PTH, Intact and Calcium",
    Price = 93.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "793X",
    Description = "Reticulocyte Count",
    Price = 22.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "17669X",
    Description = "Rheumatoid Arthritis Panel",
    Price = 159.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4418X",
    Description = "Rheumatoid Factor",
    Price = 13.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "36126X",
    Description = "RPR w/Reflex (DX)",
    Price = 4.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "799X",
    Description = "RPR Screen w/Reflex (Monitoring)",
    Price = 4.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "802X",
    Description = "Rubella Ab IgG",
    Price = 16.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "836X",
    Description = "Sodium",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "34429X",
    Description = "T3, Free",
    Price = 87.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "859X",
    Description = "T3, Total",
    Price = 20.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "861X",
    Description = "T3, Uptake",
    Price = 14.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "866X",
    Description = "T4, Free",
    Price = 13.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "867X",
    Description = "T4, Total",
    Price = 13.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "873X",
    Description = "Testosterone, Total",
    Price = 10.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "36170X",
    Description = "Testosterone, Total & Free",
    Price = 150.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "7444X",
    Description = "Thyroid Panel + TSH",
    Price = 116.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "896X",
    Description = "Triglycerides",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "899X",
    Description = "TSH (3rd generation)",
    Price = 13.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "36127X",
    Description = "TSH w/Reflex",
    Price = 13.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "6448X",
    Description = "UA, Dipstick only",
    Price = 6.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "7909X",
    Description = "UA, Dipstick w/Reflex to microscopic",
    Price = 6.25M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "5463X",
    Description = "UA, Complete (Dipstick and Microscopic)",
    Price = 8.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "294X",
    Description = "Urea Nitrogen",
    Price = 4.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "905X",
    Description = "Uric Acid",
    Price = 4.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "7065X",
    Description = "Vitamin B12 & Folate",
    Price = 113.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "927X",
    Description = "Vitamin B12, Serum",
    Price = 16.50M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "17306X",
    Description = "QuestAssureD™ 25-OH",
    Price = 72.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "91935X",
    Description = "QuestAssureD™ 25-OH Infant",
    Price = 72.00M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4439X",
    Description = "VCZ AB (IgG), EIA",
    Price = 65.75M,
    Category = testCategory.OtherTests
},
new labTest
{
    testCode = "4485X",
    Description = "Beta Strep Culture Grp A Throat",
    Price = 29.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "5617X",
    Description = "Beta Strep Culture Grp B Genital",
    Price = 38.75M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "14577X",
    Description = "BV Vaginitis Panel",
    Price = 130.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "4550X",
    Description = "Culture, Aerobic",
    Price = 32.50M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "4446X",
    Description = "Culture, Aerobic & Anaerobic",
    Price = 111.25M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "389X",
    Description = "Culture, Blood",
    Price = 99.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "4558X",
    Description = "Culture, Genital",
    Price = 20.75M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "2692X",
    Description = "Culture, Herpes Simplex Rapid",
    Price = 104.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "2649X",
    Description = "Culture, HSV, Rapid w/Typing",
    Price = 104.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "4556X",
    Description = "Culture, Sputum w/ Gram Stain",
    Price = 47.75M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "394X",
    Description = "Culture, Throat",
    Price = 36.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "395X",
    Description = "Culture, Urine, Routine (inc. indwelling cath.)",
    Price = 9.00M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "497X",
    Description = "Gram Stain",
    Price = 22.50M,
    Category = testCategory.InternalOnly
},
new labTest
{
    testCode = "237X",
    Description = "Alpha-Fetoprotein, Tumor Marker",
    Price = 62.25M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "255X",
    Description = "DNA (ds) Antibody",
    Price = 25.75M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "383X",
    Description = "Cryoglobulin, Qualitative Analysis",
    Price = 17.50M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "718X",
    Description = "Phosphate (as Phosphorus)",
    Price = 3.50M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "4021X",
    Description = "Estradiol",
    Price = 101.25M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "5081X",
    Description = "Thyroid Peroxidase Antibodies (TPO)",
    Price = 26.75M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "8475X",
    Description = "Hepatitis B Surface Antibody, Quantitative",
    Price = 58.75M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "9944F",
    Description = "Sm and Sm/RNP Antibodies",
    Price = 50.00M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "11348X",
    Description = "Hepatitis C Viral RNA, Reflex to Quantitative, Real-Time PCR with Genotype LiPA",
    Price = 140.00M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "16558X",
    Description = "Vitamin D, 1, 25-Dihydroxy, LC/MS/MS",
    Price = 191.50M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "16603X",
    Description = "QuantiFERON-TB Gold (Draw Site Incubated)",
    Price = 253.00M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "20396P",
    Description = "CEA",
    Price = 60.50M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "29493X",
    Description = "CA 27.29",
    Price = 65.50M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "30551X",
    Description = "TSI (Thyroid Stimulating Immunoglobulin)",
    Price = 182.25M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "37811X",
    Description = "Hepatitis C Viral RNA, Genotype, LiPA",
    Price = 430.75M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "90077X",
    Description = "ANA, IFA Sjogren's Panel with Reflex to ANA Titer and Pattern",
    Price = 326.25M,
    Category = testCategory.NotListed
},
new labTest
{
    testCode = "90814X",
    Description = "Thyroid Cancer Monitoring",
    Price = 420.25M,
    Category = testCategory.NotListed
}
);
                context.SaveChanges();

            }
        }
    }
}
