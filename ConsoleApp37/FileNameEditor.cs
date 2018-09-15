namespace ConsoleApp37
{
    public class FileNameEditor
    {
        private string fileName = "a";
        private string fileNameModified = "a";
        public string FileName
        {
            get
            {
                string fileNameModified = SuraName(fileName);
                return fileNameModified;
            }
            set
            {
                fileName = value;
            }
        }
        private string SuraName(string fileName)
        {
            fileName = fileName.Remove(0, 6);
            fileName = fileName.Remove(7, 4);
            string[] suraVerse = fileName.Split('-');
            if ( suraVerse[0].Contains("001"))
            {
                fileName = fileName.Insert(3, "[Al-Fatihah (The Opening)], Verse");
            }
            else if (suraVerse[0].Contains("002"))
            {
                fileName = fileName.Insert(3, "[Al-Baqarah (The Cow)], Verse");
            }
            else if (suraVerse[0].Contains("003"))
            {
                fileName = fileName.Insert(3, "[Al-Imran (The Family of Imran)], Verse");
            }
            else if (suraVerse[0].Contains("004"))
            {
                fileName = fileName.Insert(3, "[An-Nisa (The Women)], Verse");
            }
            else if (suraVerse[0].Contains("005"))
            {
                fileName = fileName.Insert(3, "[Al-Maidah (The Table spread with Food)], Verse");
            }
            else if (suraVerse[0].Contains("006"))
            {
                fileName = fileName.Insert(3, "[Al-An'am (The Cattle)");
            }
            else if (suraVerse[0].Contains("007"))
            {
                fileName = fileName.Insert(3, "[Al-A'raf (The Heights)], Verse");
            }
            else if (suraVerse[0].Contains("008"))
            {
                fileName = fileName.Insert(3, "[Al-Anfal (The Spoils of War)], Verse");
            }
            else if (suraVerse[0].Contains("009"))
            {
                fileName = fileName.Insert(3, "[At-Taubah (The Repentance)], Verse");
            }
            else if (suraVerse[0].Contains("010"))
            {
                fileName = fileName.Insert(3, "[Yunus (Jonah)], Verse");
            }
            else if (suraVerse[0].Contains("011"))
            {
                fileName = fileName.Insert(3, "[Hud (Hud)], Verse");
            }
            else if (suraVerse[0].Contains("012"))
            {
                fileName = fileName.Insert(3, "[Yusuf (Joseph)], Verse");
            }
            else if (suraVerse[0].Contains("013"))
            {
                fileName = fileName.Insert(3, "[Ar-Ra'd (The Thunder)], Verse");
            }
            else if (suraVerse[0].Contains("014"))
            {
                fileName = fileName.Insert(3, "[Ibrahim (Abraham)], Verse");
            }
            else if (suraVerse[0].Contains("015"))
            {
                fileName = fileName.Insert(3, "[Al-Hijr (The Rocky Tract)], Verse");
            }
            else if (suraVerse[0].Contains("016"))
            {
                fileName = fileName.Insert(3, "[An-Nahl (The Bees)], Verse");
            }
            else if (suraVerse[0].Contains("017"))
            {
                fileName = fileName.Insert(3, "[Al-Isra (The Night Journey)], Verse");
            }
            else if (suraVerse[0].Contains("018"))
            {
                fileName = fileName.Insert(3, "[Al-Kahf (The Cave)], Verse");
            }
            else if (suraVerse[0].Contains("019"))
            {
                fileName = fileName.Insert(3, "[Maryam (Mary)], Verse");
            }
            else if (suraVerse[0].Contains("020"))
            {
                fileName = fileName.Insert(3, "[Taha], Verse");
            }
            else if (suraVerse[0].Contains("021"))
            {
                fileName = fileName.Insert(3, "[Al-Anbiya (The Prophets)], Verse");
            }
            else if (suraVerse[0].Contains("022"))
            {
                fileName = fileName.Insert(3, "[Al-Hajj (The Pilgrimage)], Verse");
            }
            else if (suraVerse[0].Contains("023"))
            {
                fileName = fileName.Insert(3, "[Al-Mu'minoon (The Believers)], Verse");
            }
            else if (suraVerse[0].Contains("024"))
            {
                fileName = fileName.Insert(3, "[An-Noor (The Light)], Verse");
            }
            else if (suraVerse[0].Contains("025"))
            {
                fileName = fileName.Insert(3, "[Al-Furqan (The Criterion)], Verse");
            }
            else if (suraVerse[0].Contains("026"))
            {
                fileName = fileName.Insert(3, "[Ash-Shuara (The Poets)], Verse");
            }
            else if (suraVerse[0].Contains("027"))
            {
                fileName = fileName.Insert(3, "[An-Naml (The Ants)], Verse");
            }
            else if (suraVerse[0].Contains("028"))
            {
                fileName = fileName.Insert(3, "[Al-Qasas (The Stories)], Verse");
            }
            else if (suraVerse[0].Contains("029"))
            {
                fileName = fileName.Insert(3, "[Al-Ankaboot (The Spider)], Verse");
            }
            else if (suraVerse[0].Contains("030"))
            {
                fileName = fileName.Insert(3, "[Ar-Room (The Romans)], Verse");
            }
            else if (suraVerse[0].Contains("031"))
            {
                fileName = fileName.Insert(3, "[Luqman], Verse");
            }
            else if (suraVerse[0].Contains("032"))
            {
                fileName = fileName.Insert(3, "[As-Sajdah (The Prostration)], Verse");
            }
            else if (suraVerse[0].Contains("033"))
            {
                fileName = fileName.Insert(3, "[Al-Ahzab (The Combined Forces)], Verse");
            }
            else if (suraVerse[0].Contains("034"))
            {
                fileName = fileName.Insert(3, "[Saba (Sheba)], Verse");
            }
            else if (suraVerse[0].Contains("035"))
            {
                fileName = fileName.Insert(3, "[Fatir (The Originator)], Verse");
            }
            else if (suraVerse[0].Contains("036"))
            {
                fileName = fileName.Insert(3, "[Ya-seen], Verse");
            }
            else if (suraVerse[0].Contains("037"))
            {
                fileName = fileName.Insert(3, "[As-Saaffat (Those Ranges in Ranks)], Verse");
            }
            else if (suraVerse[0].Contains("038"))
            {
                fileName = fileName.Insert(3, "[Sad (The Letter Sad)], Verse");
            }
            else if (suraVerse[0].Contains("039"))
            {
                fileName = fileName.Insert(3, "[Az-Zumar (The Groups)], Verse");
            }
            else if (suraVerse[0].Contains("040"))
            {
                fileName = fileName.Insert(3, "[Ghafir (The Forgiver God)], Verse");
            }
            else if (suraVerse[0].Contains("041"))
            {
                fileName = fileName.Insert(3, "[Fussilat (Explained in Detail)], Verse");
            }
            else if (suraVerse[0].Contains("042"))
            {
                fileName = fileName.Insert(3, "[Ash-Shura (Consultation)], Verse");
            }
            else if (suraVerse[0].Contains("043"))
            {
                fileName = fileName.Insert(3, "[Az-Zukhruf (The Gold Adornment)], Verse");
            }
            else if (suraVerse[0].Contains("044"))
            {
                fileName = fileName.Insert(3, "[Ad-Dukhan (The Smoke)], Verse");
            }
            else if (suraVerse[0].Contains("045"))
            {
                fileName = fileName.Insert(3, "[Al-Jathiya (Crouching)], Verse");
            }
            else if (suraVerse[0].Contains("046"))
            {
                fileName = fileName.Insert(3, "[Al-Ahqaf (The Curved Sand-hills)	], Verse");
            }
            else if (suraVerse[0].Contains("047"))
            {
                fileName = fileName.Insert(3, "[Muhammad], Verse");
            }
            else if (suraVerse[0].Contains("048"))
            {
                fileName = fileName.Insert(3, "[Al-Fath (The Victory)], Verse");
            }
            else if (suraVerse[0].Contains("049"))
            {
                fileName = fileName.Insert(3, "[Al-Hujurat (The Dwellings)], Verse");
            }
            else if (suraVerse[0].Contains("050"))
            {
                fileName = fileName.Insert(3, "[Qaf (The Letter Qaf)], Verse");
            }
            else if (suraVerse[0].Contains("051"))
            {
                fileName = fileName.Insert(3, "[Adh-Dhariyat (The Wind that Scatter)], Verse");
            }
            else if (suraVerse[0].Contains("052"))
            {
                fileName = fileName.Insert(3, "[At-Tur (The Mount)], Verse");
            }
            else if (suraVerse[0].Contains("053"))
            {
                fileName = fileName.Insert(3, "[An-Najm (The Star)], Verse");
            }
            else if (suraVerse[0].Contains("054"))
            {
                fileName = fileName.Insert(3, "[Al-Qamar (The Moon)], Verse");
            }
            else if (suraVerse[0].Contains("055"))
            {
                fileName = fileName.Insert(3, "[Ar-Rahman (The Most Graciouse)], Verse");
            }
            else if (suraVerse[0].Contains("056"))
            {
                fileName = fileName.Insert(3, "[Al-Waqi'ah (The Event)], Verse");
            }
            else if (suraVerse[0].Contains("057"))
            {
                fileName = fileName.Insert(3, "[Al-Hadid (The Iron)], Verse");
            }
            else if (suraVerse[0].Contains("058"))
            {
                fileName = fileName.Insert(3, "[Al-Mujadilah (She That Disputeth)], Verse");
            }
            else if (suraVerse[0].Contains("059"))
            {
                fileName = fileName.Insert(3, "[Al-Hashr (The Gathering)], Verse");
            }
            else if (suraVerse[0].Contains("060"))
            {
                fileName = fileName.Insert(3, "[Al-Mumtahanah (The Woman to be examined)], Verse");
            }
            else if (suraVerse[0].Contains("061"))
            {
                fileName = fileName.Insert(3, "[As-Saff (The Row)], Verse");
            }
            else if (suraVerse[0].Contains("062"))
            {
                fileName = fileName.Insert(3, "[Al-Jumu'ah (The Congregation)], Verse");
            }
            else if (suraVerse[0].Contains("063"))
            {
                fileName = fileName.Insert(3, "[Al-Munafiqun (The Hypocrites)], Verse");
            }
            else if (suraVerse[0].Contains("064"))
            {
                fileName = fileName.Insert(3, "[At-Taghabun (The Manifestation of Losses)], Verse");
            }
            else if (suraVerse[0].Contains("065"))
            {
                fileName = fileName.Insert(3, "[At-Talaq (Divorce)], Verse");
            }
            else if (suraVerse[0].Contains("066"))
            {
                fileName = fileName.Insert(3, "[At-Tahrim (The Prohibition)], Verse");
            }
            else if (suraVerse[0].Contains("067"))
            {
                fileName = fileName.Insert(3, "[Al-Mulk (The Kingdom)], Verse");
            }
            else if (suraVerse[0].Contains("068"))
            {
                fileName = fileName.Insert(3, "[Al-Qalam (The Pen)], Verse");
            }
            else if (suraVerse[0].Contains("069"))
            {
                fileName = fileName.Insert(3, "[Al-Haqqah (The Sure Truth)], Verse");
            }
            else if (suraVerse[0].Contains("070"))
            {
                fileName = fileName.Insert(3, "[Al-Ma'arij (The Ways of Ascent)], Verse");
            }
            else if (suraVerse[0].Contains("071"))
            {
                fileName = fileName.Insert(3, "[Nuh (Noah)], Verse");
            }
            else if (suraVerse[0].Contains("072"))
            {
                fileName = fileName.Insert(3, "[Al-Jinn (The Jinn)], Verse");
            }
            else if (suraVerse[0].Contains("073"))
            {
                fileName = fileName.Insert(3, "[Al-Muzzammil], Verse");
            }
            else if (suraVerse[0].Contains("074"))
            {
                fileName = fileName.Insert(3, "[Al-Muddaththir], Verse");
            }
            else if (suraVerse[0].Contains("075"))
            {
                fileName = fileName.Insert(3, "[Al-Qiyamah (The Resurrection)], Verse");
            }
            else if (suraVerse[0].Contains("076"))
            {
                fileName = fileName.Insert(3, "[Al-Insan (The Man)], Verse");
            }
            else if (suraVerse[0].Contains("077"))
            {
                fileName = fileName.Insert(3, "[Al-Mursalat (Those Sent Forth)], Verse");
            }
            else if (suraVerse[0].Contains("078"))
            {
                fileName = fileName.Insert(3, "[An-Naba' (The Announcement)], Verse");
            }
            else if (suraVerse[0].Contains("079"))
            {
                fileName = fileName.Insert(3, "[An-Nazi'at (Those Who Yearn)], Verse");
            }
            else if (suraVerse[0].Contains("080"))
            {
                fileName = fileName.Insert(3, "['Abasa (He Frowned)], Verse");
            }
            else if (suraVerse[0].Contains("081"))
            {
                fileName = fileName.Insert(3, "[At-Takwir (The Folding Up)], Verse");
            }
            else if (suraVerse[0].Contains("082"))
            {
                fileName = fileName.Insert(3, "[Al-Infitar (The Cleaving)], Verse");
            }
            else if (suraVerse[0].Contains("083"))
            {
                fileName = fileName.Insert(3, "[At-Tatfif (Default in Duty)], Verse");
            }
            else if (suraVerse[0].Contains("084"))
            {
                fileName = fileName.Insert(3, "[Al-Inshiqaq (The Bursting Asunder)], Verse");
            }
            else if (suraVerse[0].Contains("085"))
            {
                fileName = fileName.Insert(3, "[Al-Buruj (The Stars)], Verse");
            }
            else if (suraVerse[0].Contains("086"))
            {
                fileName = fileName.Insert(3, "[At-Tariq (The Comer by Night)], Verse");
            }
            else if (suraVerse[0].Contains("087"))
            {
                fileName = fileName.Insert(3, "[Al-A'la (The Most High)], Verse");
            }
            else if (suraVerse[0].Contains("088"))
            {
                fileName = fileName.Insert(3, "[Al-Ghashiyah (The Overwhelming Event)], Verse");
            }
            else if (suraVerse[0].Contains("089"))
            {
                fileName = fileName.Insert(3, "[Al-Fajr (The Daybreak)], Verse");
            }
            else if (suraVerse[0].Contains("090"))
            {
                fileName = fileName.Insert(3, "[Al-Balad (The City)], Verse");
            }
            else if (suraVerse[0].Contains("091"))
            {
                fileName = fileName.Insert(3, "[Ash-Shams (The Sun)], Verse");
            }
            else if (suraVerse[0].Contains("092"))
            {
                fileName = fileName.Insert(3, "[Al-Lail (The Night)], Verse");
            }
            else if (suraVerse[0].Contains("093"))
            {
                fileName = fileName.Insert(3, "[Ad-Duha (The Brightness of the Day)], Verse");
            }
            else if (suraVerse[0].Contains("094"))
            {
                fileName = fileName.Insert(3, "[Al-Inshirah (The Expansion)], Verse");
            }
            else if (suraVerse[0].Contains("095"))
            {
                fileName = fileName.Insert(3, "[At-Tin (The Fig)], Verse");
            }
            else if (suraVerse[0].Contains("096"))
            {
                fileName = fileName.Insert(3, "[Al-'Alaq (The Clot)], Verse");
            }
            else if (suraVerse[0].Contains("097"))
            {
                fileName = fileName.Insert(3, "[Al-Qadr (The Majesty)], Verse");
            }
            else if (suraVerse[0].Contains("098"))
            {
                fileName = fileName.Insert(3, "[Al-Bayyinah (The Clear Evidence)], Verse");
            }
            else if (suraVerse[0].Contains("099"))
            {
                fileName = fileName.Insert(3, "[Al-Zilzal (The Shaking)], Verse");
            }
            else if (suraVerse[0].Contains("100"))
            {
                fileName = fileName.Insert(3, "[Al-'Adiyat (The Assaulters)], Verse");
            }
            else if (suraVerse[0].Contains("101"))
            {
                fileName = fileName.Insert(3, "[Al-Qari'ah (The Calamity)], Verse");
            }
            else if (suraVerse[0].Contains("102"))
            {
                fileName = fileName.Insert(3, "[At-Takathur (The Abundance of Wealth)], Verse");
            }
            else if (suraVerse[0].Contains("103"))
            {
                fileName = fileName.Insert(3, "[Al-'Asr (The Time)], Verse");
            }
            else if (suraVerse[0].Contains("104"))
            {
                fileName = fileName.Insert(3, "[Al-Humazah (The Slanderer)], Verse");
            }
            else if (suraVerse[0].Contains("105"))
            {
                fileName = fileName.Insert(3, "[Al-Fil (The Elephant)], Verse");
            }
            else if (suraVerse[0].Contains("106"))
            {
                fileName = fileName.Insert(3, "[Al-Quraish (The Quraish)], Verse");
            }
            else if (suraVerse[0].Contains("107"))
            {
                fileName = fileName.Insert(3, "[Al-Ma'un (Acts of Kindness)], Verse");
            }
            else if (suraVerse[0].Contains("108"))
            {
                fileName = fileName.Insert(3, "[Al-Kauthar (The Abundance of Good)], Verse");
            }
            else if (suraVerse[0].Contains("109"))
            {
                fileName = fileName.Insert(3, "[Al-Kafirun (The Disbelievers)], Verse");
            }
            else if (suraVerse[0].Contains("110"))
            {
                fileName = fileName.Insert(3, "[An-Nasr (The Help)], Verse");
            }
            else if (suraVerse[0].Contains("111"))
            {
                fileName = fileName.Insert(3, "[Al-Lahab (The Flame)], Verse");
            }
            else if (suraVerse[0].Contains("112"))
            {
                fileName = fileName.Insert(3, "[Al-Ikhlas (The Unity)], Verse");
            }
            else if (suraVerse[0].Contains("113"))
            {
                fileName = fileName.Insert(3, "[Al-Falaq (The Dawn)], Verse");
            }
            else if (suraVerse[0].Contains("114"))
            {
                fileName = fileName.Insert(3, "[An-Nas (The Men)], Verse");
            }
            string fileNameModified = fileName;
            return fileNameModified;
        }
    }
}
