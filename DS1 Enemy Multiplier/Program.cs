using SoulsFormats;
namespace DS1_Enemy_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duplicate enemies how many times? 2 = Double, 4 = Quadruple for example.");
            int AmountToDuplicate = Convert.ToInt32(Console.ReadLine());

            MSB1 firelink = MSB1.Read(@"map\MapStudio\m10_02_00_00.msb"); //24
            MSB1 depths = MSB1.Read(@"map\MapStudio\m10_00_00_00.msb");
            MSB1 burg = MSB1.Read(@"map\MapStudio\m10_01_00_00.msb");
            MSB1 paintedworld = MSB1.Read(@"map\MapStudio\m11_00_00_00.msb");
            MSB1 garden = MSB1.Read(@"map\MapStudio\m12_00_00_01.msb");
            MSB1 royalwood = MSB1.Read(@"map\MapStudio\m12_01_00_00.msb");
            MSB1 catacombs = MSB1.Read(@"map\MapStudio\m13_00_00_00.msb");
            MSB1 tog = MSB1.Read(@"map\MapStudio\m13_01_00_00.msb");
            MSB1 greathollow = MSB1.Read(@"map\MapStudio\m13_02_00_00.msb");
            MSB1 blight = MSB1.Read(@"map\MapStudio\m14_00_00_00.msb");
            MSB1 demonruins = MSB1.Read(@"map\MapStudio\m14_01_00_00.msb");
            MSB1 sens = MSB1.Read(@"map\MapStudio\m15_00_00_00.msb");
            MSB1 alondo = MSB1.Read(@"map\MapStudio\m15_01_00_00.msb");
            MSB1 newlondo = MSB1.Read(@"map\MapStudio\m16_00_00_00.msb");
            MSB1 archives = MSB1.Read(@"map\MapStudio\m17_00_00_00.msb");
            MSB1 kiln = MSB1.Read(@"map\MapStudio\m18_00_00_00.msb");
            MSB1 asylum = MSB1.Read(@"map\MapStudio\m18_01_00_00.msb");

            /*int counter = 1;
            foreach (var Enemy in asylum.Parts.Enemies)
            {
               Console.WriteLine("{0} is the {1} enemy.",Enemy.Name,counter);
               counter++;
            }*/
            
            for (int j = 1;  j < AmountToDuplicate; j++)
            {
                for (int i = 0; i < 41; i++)
                {
                    if (firelink.Parts.Enemies[i].Name.Contains("c0000") || firelink.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        firelink.Parts.Enemies.Add(firelink.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 93; i++)
                {
                    if (depths.Parts.Enemies[i].Name.Contains("c0000") || depths.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        depths.Parts.Enemies.Add(depths.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 174; i++)
                {
                    if (burg.Parts.Enemies[i].Name.Contains("c0000") || burg.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        burg.Parts.Enemies.Add(burg.Parts.Enemies[i]);
                    }
                }
                
                for (int i = 0; i < 113; i++)
                {
                    if (paintedworld.Parts.Enemies[i].Name.Contains("c0000") || paintedworld.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        paintedworld.Parts.Enemies.Add(paintedworld.Parts.Enemies[i]);
                    }
                }
                
                for (int i = 0; i < 106; i++)
                {
                    if (garden.Parts.Enemies[i].Name.Contains("c0000") || garden.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        garden.Parts.Enemies.Add(garden.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 206; i++)
                {
                    if (royalwood.Parts.Enemies[i].Name.Contains("c0000") || royalwood.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        royalwood.Parts.Enemies.Add(royalwood.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 117; i++)
                {
                    if (catacombs.Parts.Enemies[i].Name.Contains("c0000") || catacombs.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        catacombs.Parts.Enemies.Add(catacombs.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 90; i++)
                {
                    if (tog.Parts.Enemies[i].Name.Contains("c0000") || tog.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        tog.Parts.Enemies.Add(tog.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 58; i++)
                {
                    if (greathollow.Parts.Enemies[i].Name.Contains("c0000") || greathollow.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        greathollow.Parts.Enemies.Add(greathollow.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 154; i++)
                {
                    if (blight.Parts.Enemies[i].Name.Contains("c0000") || blight.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        blight.Parts.Enemies.Add(blight.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 246; i++)
                {
                    if (demonruins.Parts.Enemies[i].Name.Contains("c0000") || demonruins.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        demonruins.Parts.Enemies.Add(demonruins.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 61; i++)
                {
                    if (sens.Parts.Enemies[i].Name.Contains("c0000") || sens.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        sens.Parts.Enemies.Add(sens.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 101; i++)
                {
                    if (alondo.Parts.Enemies[i].Name.Contains("c0000") || alondo.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        alondo.Parts.Enemies.Add(alondo.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 108; i++)
                {
                    if (newlondo.Parts.Enemies[i].Name.Contains("c0000") || newlondo.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        newlondo.Parts.Enemies.Add(newlondo.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 125; i++)
                {
                    if (archives.Parts.Enemies[i].Name.Contains("c0000") || archives.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        archives.Parts.Enemies.Add(archives.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 24; i++)
                {
                    if (kiln.Parts.Enemies[i].Name.Contains("c0000") || kiln.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        kiln.Parts.Enemies.Add(kiln.Parts.Enemies[i]);
                    }
                }

                for (int i = 0; i < 35; i++)
                {
                    if (asylum.Parts.Enemies[i].Name.Contains("c0000") || asylum.Parts.Enemies[i].Name.Contains("c1000"))
                    {

                    }
                    else
                    {
                        asylum.Parts.Enemies.Add(asylum.Parts.Enemies[i]);
                    }
                }

            }

            firelink.Write(@"map\MapStudio\m10_02_00_00.msb");
            depths.Write(@"map\MapStudio\m10_00_00_00.msb");
            burg.Write(@"map\MapStudio\m10_01_00_00.msb");
            paintedworld.Write(@"map\MapStudio\m11_00_00_00.msb");
            garden.Write(@"map\MapStudio\m12_00_00_01.msb");
            royalwood.Write(@"map\MapStudio\m12_01_00_00.msb");
            catacombs.Write(@"map\MapStudio\m13_00_00_00.msb");
            tog.Write(@"map\MapStudio\m13_01_00_00.msb");
            greathollow.Write(@"map\MapStudio\m13_02_00_00.msb");
            blight.Write(@"map\MapStudio\m14_00_00_00.msb");
            demonruins.Write(@"map\MapStudio\m14_01_00_00.msb");
            sens.Write(@"map\MapStudio\m15_00_00_00.msb");
            alondo.Write(@"map\MapStudio\m15_01_00_00.msb");
            newlondo.Write(@"map\MapStudio\m16_00_00_00.msb");
            archives.Write(@"map\MapStudio\m17_00_00_00.msb");
            kiln.Write(@"map\MapStudio\m18_00_00_00.msb");
            asylum.Write(@"map\MapStudio\m18_01_00_00.msb");
            Console.WriteLine("Duplicating Completed. Press Enter to Close.");
            Console.ReadLine();
        }
    }
}
