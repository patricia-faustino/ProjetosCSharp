using System;
using System.Drawing;
using Robocode;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNL
{
    public class Yuno : Robot
    {
        public override void Run()
        {
            //Inicalização do robo

            Style();

            // Loop infinito até a morte do robo
            
            
            while (true)
            {
                Ahead(200);
                TurnGunLeft(360);
                Back(200);
                TurnGunRight(360);
                TurnLeft(45);
                /*
                Ahead(150);
                TurnGunLeft(360);
                Back(150);
                TurnGunRight(360);
                TurnRight(45);*/
            }
        }
        public void Style()
        {
            BodyColor = Color.Pink; // corpo
            GunColor = Color.White; // arma
            RadarColor = Color.Yellow; // radar
            BulletColor = Color.Magenta; // bala
            ScanColor = Color.Yellow; // varredura
        }

        //Se o radar encontrar um robo
        // Assumindo que o radar e a arma estão alinhados  
        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            
            //Inimigo próximo e com muita energia
            if (evnt.Distance < 50 && evnt.Energy >= 50) {
                Fire(3);
            } 
            else if(evnt.Distance < 50)
            {
                Fire(2);
            }
            else
            {
                Fire(1);
            }
            Scan();
        }

        // Quando é acertado
        // Gira perpendicurlamente em relação a direção da bala e avança
        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            TurnRight(90 - (Heading - evnt.Heading)); 
            Ahead(50); //avança
            Scan();
            //fire
        }

        // Se o robô colidir com a parede
        //Para não ficar preso anda para tras
        public override void OnHitWall(HitWallEvent evnt)
        {
            Back(20);
        }

        // Método quando um robô colide com o o outro
        public override void OnHitRobot(HitRobotEvent evnt)
        {
            
            if(evnt.Bearing > -10 && evnt.Bearing < 10)
            {
                Fire(3);
            }
            if (evnt.IsMyFault) //
            {
                Back(100);
                TurnRight(45);
                // FIRE
            }

        }
    }
}
