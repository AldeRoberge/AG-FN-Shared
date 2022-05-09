using System;

namespace AG_FishNet_Shared.Utils
{
    public static class RandomName
    {
        public static string GetRandomName()
        {
            string[] names = new string[]
            {
                "Darq",
                "Deyst",
                "Drac",
                "Drol",
                "Eango",
                "Eashy",
                "Eati",
                "Eendi",
                "Ehoni",
                "Gharr",
                "Iatho",
                "Iawa",
                "Idrae",
                "Iri",
                "Issz",
                "Itani",
                "Laen",
                "Lauk",
                "Lorz",
                "Oalei",
                "Odaru",
                "Oeti",
                "Orothi",
                "Oshyu",
                "Queq",
                "Radph",
                "Rayr",
                "Ril",
                "Rilr",
                "Risrr",
                "Saylt",
                "Scheev",
                "Sek",
                "Serl",
                "Seus",
                "Tal",
                "Tiar",
                "Uoro",
                "Urake",
                "Utanu",
                "Vorck",
                "Vorv",
                "Yangu",
                "Yimi",
                "Zhiar"
            };

            return names[new Random().Next(0, names.Length)];
        }
    }
}