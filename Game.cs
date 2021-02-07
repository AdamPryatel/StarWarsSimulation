using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Game
    {

        public Game()
        {

        }

        public string[] lightSideArray = new string[] { "Luke Skywalker", "Obi-Wan", "Han Solo" };

        public string[] darkSideArray = new string[] { "Darth Sidious", "Darth Vader", "Boba Fett" };

        public int LukeHealth { get; set; } = 500;
        public int ObiWanHealth {get;set; } = 500;
        public int HanSoloHealth { get; set; } = 500;
        public int DarthSidiousHealth { get; set; } = 500;
        public int DarthVaderHealth { get; set; } = 500;
        public int BobaFettHealth { get; set; } = 500;



        public int GetLukeHealth()
        {
            return LukeHealth;
        }

        public int GetObiWanHealth()
        {
            return ObiWanHealth;
        }

        public int GetHanSoloHealth()
        {
            return HanSoloHealth;
        }

        public int GetDarthSidiousHealth()
        {
            return DarthSidiousHealth;
        }

        public int GetDarthVaderHealth()
        {
            return DarthVaderHealth;
        }

        public int GetBobaFettHealth()
        {
            return BobaFettHealth;
        }

        // Luke

        public void LukeLightSaberdamage()
        {
            DarthVaderHealth -= 40;
            DarthSidiousHealth -= 10;
            BobaFettHealth -= 80;
        }

        public void LukeForcePushDamage()
        {
            DarthVaderHealth -= 10;
            DarthSidiousHealth -= 10;
            BobaFettHealth -= 10;
        }


        // Obi-Wan

        public void ObiWanLightSaberDamage()
        {
            DarthVaderHealth -= 60;
            DarthSidiousHealth -= 20;
            BobaFettHealth -= 20;
        }

        public void JediMindTricks()
        {
            Console.WriteLine("These are not the Droids You Are Looking For!");

            LukeHealth += 30;
            ObiWanHealth += 50;
            HanSoloHealth += 30;
        }



        // Han solo

        public void QuickShot()
        {
            Console.WriteLine("Han DID shoot first");

            DarthVaderHealth -= 30;
            DarthSidiousHealth -= 30;
            BobaFettHealth -= 30;
        }

        public void Greed()
        {
            LukeHealth -= 10;
            ObiWanHealth -= 10;

            HanSoloHealth += 80;
        }

        // Emporer

        public void ForceLightning()
        {
            DarthVaderHealth -= 50;
            DarthSidiousHealth -= 70;
            BobaFettHealth -= 50;

            LukeHealth -= 100;
            ObiWanHealth -= 100;
            HanSoloHealth -= 100;
        }

        public void NearImmortality()
        {
            DarthSidiousHealth += 200;
        }


        // Vader

        public void VaderLightSaberDamage()
        {
            LukeHealth -= 40;
            ObiWanHealth -= 60;
            HanSoloHealth -= 50;
        }

        public void ForceChoke()
        {
            LukeHealth -= 20;
            ObiWanHealth -= 30;
            HanSoloHealth -= 70;
        }

        // Fett

        public void Blaster()
        {
            LukeHealth -= 30;
            ObiWanHealth -= 30;
            HanSoloHealth -= 50;
        }

        public void FlameThrower()
        {
            LukeHealth -= 40;
            ObiWanHealth -= 30;
            HanSoloHealth -= 60;
        }


    }
}
