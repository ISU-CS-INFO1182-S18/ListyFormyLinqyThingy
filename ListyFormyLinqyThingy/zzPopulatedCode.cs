using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyFormyLinqyThingy {
    class zzPopulatedCode {
        List<Citizen> citz = new List<Citizen>();
        private void PopulateCity() {
            citz.Add(new Citizen() { FirstName = "Clark", LastName = "Kent" });     //0
            citz.Add(new Citizen() { FirstName = "Bruce", LastName = "Wayne" });    //1
            citz.Add(new Citizen() { FirstName = "Diana", LastName = "Prince" });   //2
            citz.Add(new Citizen() { FirstName = "Alan", LastName = "Scott" });     //3
            citz.Add(new Citizen() { FirstName = "Barry", LastName = "Allen" });    //4
            citz.Add(new Citizen() { FirstName = "Linda", LastName = "Danvers" });  //5
            citz.Add(new Citizen() { FirstName = "Doris", LastName = "Zeul" });     //6 
            citz.Add(new Citizen() { FirstName = "Ross", MiddleName = "Zane", LastName = "Flynn", DateOfBirth = new DateTime(11, 28, 1984) });
            citz.Add(new Citizen() { FirstName = "Gay", MiddleName = "Naida", LastName = "Bullock", DateOfBirth = new DateTime(06, 21, 1992) });
            citz.Add(new Citizen() { FirstName = "Lucas", MiddleName = "Geoffrey", LastName = "Franklin", DateOfBirth = new DateTime(09, 20, 2018) });
            citz.Add(new Citizen() { FirstName = "Oscar", MiddleName = "Marshall", LastName = "Cruz", DateOfBirth = new DateTime(01, 10, 2018) });
            citz.Add(new Citizen() { FirstName = "Wang", MiddleName = "Zephania", LastName = "Guerrero", DateOfBirth = new DateTime(11, 10, 1974) });
            citz.Add(new Citizen() { FirstName = "Kevyn", MiddleName = "Dorian", LastName = "Singleton", DateOfBirth = new DateTime(03, 07, 1923) });
            citz.Add(new Citizen() { FirstName = "Chelsea", MiddleName = "Wayne", LastName = "Holcomb", DateOfBirth = new DateTime(06, 03, 1963) });
            citz.Add(new Citizen() { FirstName = "Nash", MiddleName = "Dale", LastName = "Alexander", DateOfBirth = new DateTime(02, 17, 1934) });
            citz.Add(new Citizen() { FirstName = "Sybil", MiddleName = "Brock", LastName = "Bradley", DateOfBirth = new DateTime(08, 02, 2009) });
            citz.Add(new Citizen() { FirstName = "Clark", MiddleName = "Cruz", LastName = "Alvarado", DateOfBirth = new DateTime(07, 03, 1975) });
            citz.Add(new Citizen() { FirstName = "Iris", MiddleName = "Idona", LastName = "Harding", DateOfBirth = new DateTime(10, 25, 1976) });
            citz.Add(new Citizen() { FirstName = "Alfonso", MiddleName = "Alec", LastName = "Deleon", DateOfBirth = new DateTime(06, 24, 2001) });
            citz.Add(new Citizen() { FirstName = "Nissim", MiddleName = "Britanni", LastName = "Mcmahon", DateOfBirth = new DateTime(06, 27, 1992) });
            citz.Add(new Citizen() { FirstName = "Alexis", MiddleName = "Raphael", LastName = "Stafford", DateOfBirth = new DateTime(03, 27, 1938) });
            citz.Add(new Citizen() { FirstName = "Gage", MiddleName = "Xanthus", LastName = "Knight", DateOfBirth = new DateTime(11, 06, 1967) });
            citz.Add(new Citizen() { FirstName = "Giacomo", MiddleName = "Morgan", LastName = "Robbins", DateOfBirth = new DateTime(03, 14, 1971) });
            citz.Add(new Citizen() { FirstName = "Linus", MiddleName = "Sylvester", LastName = "Cochran", DateOfBirth = new DateTime(09, 19, 1935) });
            citz.Add(new Citizen() { FirstName = "Dustin", MiddleName = "Hasad", LastName = "Good", DateOfBirth = new DateTime(07, 09, 1992) });
            citz.Add(new Citizen() { FirstName = "Vernon", MiddleName = "Gage", LastName = "Peck", DateOfBirth = new DateTime(11, 05, 2017) });
            citz.Add(new Citizen() { FirstName = "Amanda", MiddleName = "Alexa", LastName = "Sparks", DateOfBirth = new DateTime(06, 11, 1992) });
            citz.Add(new Citizen() { FirstName = "Karyn", MiddleName = "George", LastName = "Wilcox", DateOfBirth = new DateTime(12, 27, 1918) });
            citz.Add(new Citizen() { FirstName = "Judah", MiddleName = "Daphne", LastName = "Ryan", DateOfBirth = new DateTime(12, 05, 1921) });
            citz.Add(new Citizen() { FirstName = "Eaton", MiddleName = "Francis", LastName = "Barker", DateOfBirth = new DateTime(05, 05, 1929) });
            citz.Add(new Citizen() { FirstName = "Quincy", MiddleName = "Cody", LastName = "Thornton", DateOfBirth = new DateTime(07, 17, 1921) });
            citz.Add(new Citizen() { FirstName = "Ignatius", MiddleName = "April", LastName = "Mckee", DateOfBirth = new DateTime(03, 07, 1947) });
            citz.Add(new Citizen() { FirstName = "Colby", MiddleName = "Leila", LastName = "Goff", DateOfBirth = new DateTime(01, 13, 1986) });
            citz.Add(new Citizen() { FirstName = "Armand", MiddleName = "Len", LastName = "Poole", DateOfBirth = new DateTime(08, 28, 2005) });
            citz.Add(new Citizen() { FirstName = "Desirae", MiddleName = "Candace", LastName = "Golden", DateOfBirth = new DateTime(09, 24, 1923) });
            citz.Add(new Citizen() { FirstName = "September", MiddleName = "Nolan", LastName = "Blackwell", DateOfBirth = new DateTime(11, 15, 1957) });
            citz.Add(new Citizen() { FirstName = "Bree", MiddleName = "Illana", LastName = "Nolan", DateOfBirth = new DateTime(05, 19, 1999) });
            citz.Add(new Citizen() { FirstName = "Eliana", MiddleName = "Blaze", LastName = "Shelton", DateOfBirth = new DateTime(04, 28, 1932) });
            citz.Add(new Citizen() { FirstName = "Iona", MiddleName = "Colleen", LastName = "Dorsey", DateOfBirth = new DateTime(03, 02, 1989) });
            citz.Add(new Citizen() { FirstName = "Mallory", MiddleName = "Nadine", LastName = "Wise", DateOfBirth = new DateTime(04, 11, 2011) });
            citz.Add(new Citizen() { FirstName = "Allegra", MiddleName = "Sarah", LastName = "Hardin", DateOfBirth = new DateTime(08, 30, 1951) });
            citz.Add(new Citizen() { FirstName = "Alexis", MiddleName = "Hedwig", LastName = "Copeland", DateOfBirth = new DateTime(02, 04, 1945) });
            citz.Add(new Citizen() { FirstName = "Lilah", MiddleName = "Kirestin", LastName = "Campos", DateOfBirth = new DateTime(11, 29, 1986) });
            citz.Add(new Citizen() { FirstName = "Timothy", MiddleName = "Emily", LastName = "Kane", DateOfBirth = new DateTime(10, 23, 1981) });
            citz.Add(new Citizen() { FirstName = "Graiden", MiddleName = "Herman", LastName = "Mcdaniel", DateOfBirth = new DateTime(12, 22, 1989) });
            citz.Add(new Citizen() { FirstName = "Vivian", MiddleName = "Kyle", LastName = "Dennis", DateOfBirth = new DateTime(10, 15, 1946) });
            citz.Add(new Citizen() { FirstName = "Arsenio", MiddleName = "Dora", LastName = "Weaver", DateOfBirth = new DateTime(07, 13, 1972) });
            citz.Add(new Citizen() { FirstName = "Kasimir", MiddleName = "Julie", LastName = "Peters", DateOfBirth = new DateTime(11, 23, 1920) });
            citz.Add(new Citizen() { FirstName = "Andrew", MiddleName = "Chadwick", LastName = "Dyer", DateOfBirth = new DateTime(08, 20, 1947) });
            citz.Add(new Citizen() { FirstName = "Whitney", MiddleName = "Ocean", LastName = "Owen", DateOfBirth = new DateTime(04, 15, 2017) });
            citz.Add(new Citizen() { FirstName = "Charles", MiddleName = "Quincy", LastName = "Cross", DateOfBirth = new DateTime(06, 18, 2000) });
            citz.Add(new Citizen() { FirstName = "Caryn", MiddleName = "Clayton", LastName = "Delgado", DateOfBirth = new DateTime(08, 11, 2014) });
            citz.Add(new Citizen() { FirstName = "Shay", MiddleName = "Halee", LastName = "Atkins", DateOfBirth = new DateTime(01, 09, 1930) });
            citz.Add(new Citizen() { FirstName = "Carissa", MiddleName = "Wyatt", LastName = "Church", DateOfBirth = new DateTime(06, 25, 1970) });
            citz.Add(new Citizen() { FirstName = "Kelly", MiddleName = "Jada", LastName = "Holman", DateOfBirth = new DateTime(03, 22, 2005) });
            citz.Add(new Citizen() { FirstName = "Callum", MiddleName = "Kalia", LastName = "Webb", DateOfBirth = new DateTime(02, 25, 1939) });
            citz.Add(new Citizen() { FirstName = "Cailin", MiddleName = "Stone", LastName = "Snider", DateOfBirth = new DateTime(01, 05, 1995) });
            citz.Add(new Citizen() { FirstName = "Wynne", MiddleName = "Neville", LastName = "Coleman", DateOfBirth = new DateTime(08, 28, 2008) });
            citz.Add(new Citizen() { FirstName = "Quinn", MiddleName = "Ezekiel", LastName = "Fitzpatrick", DateOfBirth = new DateTime(08, 06, 1927) });
            citz.Add(new Citizen() { FirstName = "Shana", MiddleName = "Brian", LastName = "Hunt", DateOfBirth = new DateTime(12, 11, 2007) });
            citz.Add(new Citizen() { FirstName = "Kirk", MiddleName = "Nevada", LastName = "Malone", DateOfBirth = new DateTime(01, 21, 1936) });
            citz.Add(new Citizen() { FirstName = "Chiquita", MiddleName = "Wylie", LastName = "Burnett", DateOfBirth = new DateTime(04, 05, 2016) });
            citz.Add(new Citizen() { FirstName = "Charissa", MiddleName = "Quinn", LastName = "Dunlap", DateOfBirth = new DateTime(09, 10, 1942) });
            citz.Add(new Citizen() { FirstName = "Minerva", MiddleName = "Quinn", LastName = "Dickson", DateOfBirth = new DateTime(01, 24, 1965) });
            citz.Add(new Citizen() { FirstName = "Geraldine", MiddleName = "Cade", LastName = "Yates", DateOfBirth = new DateTime(02, 16, 1983) });
            citz.Add(new Citizen() { FirstName = "Demetria", MiddleName = "Kylynn", LastName = "Bridges", DateOfBirth = new DateTime(02, 19, 1938) });
            citz.Add(new Citizen() { FirstName = "Eve", MiddleName = "Dustin", LastName = "Lynch", DateOfBirth = new DateTime(04, 05, 1997) });
            citz.Add(new Citizen() { FirstName = "Noah", MiddleName = "Tara", LastName = "Patrick", DateOfBirth = new DateTime(10, 01, 1977) });
            citz.Add(new Citizen() { FirstName = "Jayme", MiddleName = "Rina", LastName = "Morin", DateOfBirth = new DateTime(11, 01, 1946) });
            citz.Add(new Citizen() { FirstName = "Bruno", MiddleName = "Abdul", LastName = "Russo", DateOfBirth = new DateTime(06, 02, 1975) });
            citz.Add(new Citizen() { FirstName = "Brett", MiddleName = "Ethan", LastName = "Avery", DateOfBirth = new DateTime(10, 26, 2002) });
            citz.Add(new Citizen() { FirstName = "Anne", MiddleName = "Sylvia", LastName = "Wilcox", DateOfBirth = new DateTime(10, 31, 1988) });
            citz.Add(new Citizen() { FirstName = "Silas", MiddleName = "April", LastName = "Trujillo", DateOfBirth = new DateTime(08, 12, 1926) });
            citz.Add(new Citizen() { FirstName = "Ray", MiddleName = "Curran", LastName = "Randall", DateOfBirth = new DateTime(01, 04, 1977) });
            citz.Add(new Citizen() { FirstName = "Darryl", MiddleName = "Shea", LastName = "Armstrong", DateOfBirth = new DateTime(01, 01, 1935) });
            citz.Add(new Citizen() { FirstName = "Nash", MiddleName = "Blair", LastName = "Nicholson", DateOfBirth = new DateTime(02, 13, 1990) });
            citz.Add(new Citizen() { FirstName = "Louis", MiddleName = "Graiden", LastName = "Dalton", DateOfBirth = new DateTime(01, 16, 1928) });
            citz.Add(new Citizen() { FirstName = "Marny", MiddleName = "Cailin", LastName = "Hull", DateOfBirth = new DateTime(12, 04, 1993) });
            citz.Add(new Citizen() { FirstName = "Grant", MiddleName = "Kevin", LastName = "Beck", DateOfBirth = new DateTime(03, 18, 2005) });
            citz.Add(new Citizen() { FirstName = "Isadora", MiddleName = "Harlan", LastName = "Roman", DateOfBirth = new DateTime(05, 01, 1943) });
            citz.Add(new Citizen() { FirstName = "Kitra", MiddleName = "Quynn", LastName = "Cunningham", DateOfBirth = new DateTime(07, 13, 2008) });
            citz.Add(new Citizen() { FirstName = "Noelle", MiddleName = "Alisa", LastName = "Thornton", DateOfBirth = new DateTime(11, 03, 1965) });
            citz.Add(new Citizen() { FirstName = "Kermit", MiddleName = "Fuller", LastName = "Little", DateOfBirth = new DateTime(01, 08, 1971) });
            citz.Add(new Citizen() { FirstName = "Brandon", MiddleName = "Kane", LastName = "Burton", DateOfBirth = new DateTime(01, 22, 1919) });
            citz.Add(new Citizen() { FirstName = "Delilah", MiddleName = "Brittany", LastName = "Vincent", DateOfBirth = new DateTime(04, 15, 1984) });
            citz.Add(new Citizen() { FirstName = "Micah", MiddleName = "David", LastName = "Clay", DateOfBirth = new DateTime(01, 10, 1929) });
            citz.Add(new Citizen() { FirstName = "Boris", MiddleName = "Kai", LastName = "Neal", DateOfBirth = new DateTime(07, 27, 1988) });
            citz.Add(new Citizen() { FirstName = "Uriah", MiddleName = "Wing", LastName = "Bryan", DateOfBirth = new DateTime(05, 22, 1960) });
            citz.Add(new Citizen() { FirstName = "Fuller", MiddleName = "Barry", LastName = "Dale", DateOfBirth = new DateTime(12, 09, 2001) });
            citz.Add(new Citizen() { FirstName = "Carlos", MiddleName = "Kaitlin", LastName = "Stein", DateOfBirth = new DateTime(10, 11, 2006) });
            citz.Add(new Citizen() { FirstName = "Ray", MiddleName = "Wayne", LastName = "Madden", DateOfBirth = new DateTime(08, 14, 1942) });
            citz.Add(new Citizen() { FirstName = "Grace", MiddleName = "Stewart", LastName = "Pickett", DateOfBirth = new DateTime(09, 23, 1978) });
            citz.Add(new Citizen() { FirstName = "Austin", MiddleName = "Jerome", LastName = "Conley", DateOfBirth = new DateTime(09, 12, 1933) });
            citz.Add(new Citizen() { FirstName = "Maya", MiddleName = "Selma", LastName = "Beach", DateOfBirth = new DateTime(11, 10, 1941) });
            citz.Add(new Citizen() { FirstName = "Joel", MiddleName = "Ramona", LastName = "Heath", DateOfBirth = new DateTime(05, 11, 2001) });
            citz.Add(new Citizen() { FirstName = "Lucy", MiddleName = "Odette", LastName = "Forbes", DateOfBirth = new DateTime(08, 04, 2002) });
            citz.Add(new Citizen() { FirstName = "Catherine", MiddleName = "Cooper", LastName = "Vargas", DateOfBirth = new DateTime(12, 02, 1966) });
            citz.Add(new Citizen() { FirstName = "Rhoda", MiddleName = "Indira", LastName = "Compton", DateOfBirth = new DateTime(09, 12, 1943) });
            citz.Add(new Citizen() { FirstName = "Tyler", MiddleName = "Octavius", LastName = "Wiley", DateOfBirth = new DateTime(04, 20, 1994) });
            citz.Add(new Citizen() { FirstName = "Elizabeth", MiddleName = "Mechelle", LastName = "Lloyd", DateOfBirth = new DateTime(06, 19, 2018) });
            citz.Add(new Citizen() { FirstName = "Lareina", MiddleName = "Lars", LastName = "Mckay", DateOfBirth = new DateTime(08, 06, 2001) });
            citz.Add(new Citizen() { FirstName = "Hilda", MiddleName = "Edan", LastName = "Clay", DateOfBirth = new DateTime(02, 13, 2017) });
            citz.Add(new Citizen() { FirstName = "Audra", MiddleName = "Victor", LastName = "Brooks", DateOfBirth = new DateTime(06, 06, 1998) });
            citz.Add(new Citizen() { FirstName = "Fulton", MiddleName = "Arthur", LastName = "Bradford", DateOfBirth = new DateTime(02, 27, 1960) });
            citz.Add(new Citizen() { FirstName = "Nigel", MiddleName = "Rafael", LastName = "Christensen", DateOfBirth = new DateTime(12, 19, 1928) });
            citz.Add(new Citizen() { FirstName = "Lois", MiddleName = "Jaime", LastName = "Valentine", DateOfBirth = new DateTime(04, 09, 1990) });
            citz.Add(new Citizen() { FirstName = "Imani", MiddleName = "Cassady", LastName = "Becker", DateOfBirth = new DateTime(10, 17, 1925) });
        }

        private void MakeSupers() {
            List<SuperHero> sups = new List<SuperHero>();

            sups.Add(new SuperHero("Superman", "") { SecretIdentity = citz[0] });
            sups.Add(new SuperHero("Batman", "") { SecretIdentity = citz[1] });
            sups.Add(new SuperHero("Wonder", "Woman") { SecretIdentity = citz[2] });
            sups.Add(new SuperHero("Green", "Lantern") { SecretIdentity = citz[3] });
            sups.Add(new SuperHero("The", "Flash") { SecretIdentity = citz[4] });
            sups.Add(new SuperHero("Supegirl", "") { SecretIdentity = citz[5] });
            sups.Add(new SuperHero("Aquaman", ""));
        }
        private void MakeBaddies() {
            List<Villian> vils = new List<Villian>();
            vils.Add(new Villian() { FirstName = "Lex", LastName = "Luther" });
            vils.Add(new Villian() { FirstName = "Joker" });
            vils.Add(new Villian() { FirstName = "Bane" });
            vils.Add(new Villian() { FirstName = "Sinestro" });
            vils.Add(new Villian() { FirstName = "Felix", LastName = "Faust" });
            vils.Add(new Villian() { FirstName = "Doomsday" });
            vils.Add(new Villian() { FirstName = "Circe" });
            vils.Add(new Villian() { FirstName = "Gigantica" });
            vils.Add(new Villian() { FirstName = "Harley" });

        }
    }
}
