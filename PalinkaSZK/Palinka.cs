    using System;
    using System.ComponentModel.DataAnnotations;

namespace PalinkaSZK
    {
        internal class Palinka
        {  
            [Required]
            private string? gyumolcs;
            public int AlkoholFok { get; set; }
            public string? Gyumolcs {
                get => gyumolcs;
                set {
                    if (value is null) throw new Exception(
                    "A gyümölcs értéke nem lehet null");

                    if (value.Length < 3 || value.Length > 20) throw new Exception(
                        $"Az érték, amit szeretnél beállítani a gyümölcsre: {value}\n" +
                        $"Ennek a hossza: {value.Length}.\n A gyümölcs hossza csak [3, 20] között lehet!");

                    gyumolcs = value;
                }
            }
            public int Mennyiseg {  get; set; }
            public int KeszitesEv { get; set; }
            public int AlkoholAr { get; set; }

            public Palinka(int alkoholFok, string gyumolcs, int mennyiseg, int keszitesEv, int alkoholAr)
            {
                AlkoholFok = alkoholFok;
                Gyumolcs = gyumolcs;
                Mennyiseg = mennyiseg;
                KeszitesEv = keszitesEv;
                AlkoholAr = alkoholAr;
            }

            public override string ToString()
            {
                return $"Alkohol fok: {AlkoholFok}\nGyümölcs: {Gyumolcs}\nMennyiség: {Mennyiseg} deciliter\nKészítés éve: {KeszitesEv}\nÁr: {AlkoholAr} ft/deciliter\n\n";
            }
        }
    }
