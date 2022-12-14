start:
/*--DADES--*/
///////////////////////////////////////////////////////////////////////////
Random numgen = new Random();

int round = 1;

int mppot = numgen.Next(2, 5);
int mppotoriginal = mppot;

int hp = numgen.Next(850, 1255);
int hporiginal = hp;
int sp = numgen.Next(60, 128);
int sporiginal = sp;


int curaenemic = numgen.Next(3, 8);

int enemyhp = numgen.Next(650, 950);
int enemyhporiginal = enemyhp;
///////////////////////////////////////////////////////////////////////////


/*--FUNCIONS HEROI--*/
///////////////////////////////////////////////////////////////////////////

static void atacar(ref int enemyhpx)
{
    Random numgen = new Random();
    int chance = numgen.Next(1, 16);
    int value = numgen.Next(50, 150);

    if (chance == 2)
    {
        Console.WriteLine("You missed the attack");
        Console.ReadKey();
    }

    else
    {
        enemyhpx -= value;

        Console.WriteLine();
        Console.Write("Slime receives ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value + " damage points");
        if (value > 140) Console.WriteLine("CRITICAL!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("#                                       ");
        Console.WriteLine("   #*#*  **                             ");
        Console.WriteLine("   ### ##                               ");
        Console.WriteLine(" #  *###**#*                            ");
        Console.WriteLine("       #### ##              #######     ");
        Console.WriteLine("         *###**#* **       *#######*    ");
        Console.WriteLine("            #######        ####   ##    ");
        Console.WriteLine("             *##*###*      *## *##*     ");
        Console.WriteLine("                    ######    ###       ");
        Console.WriteLine("                       ***#########*    ");
        Console.WriteLine("                        #   #########   ");
        Console.WriteLine("                     **    *###### ##   ");
        Console.WriteLine("                ##   ###    ###### ##   ");
        Console.WriteLine("              *****      *###*  *##*    ");
        Console.WriteLine("                         ###      ###   ");
        Console.WriteLine("                         *##      ##*  ");
        Console.WriteLine();

        Console.ResetColor();
        Console.ReadKey();
    }
}

static void curar(int hporiginal, ref int hpx, ref int spx)
{
    Random numgen = new Random();
    int chance = numgen.Next(1, 11);
    int value = numgen.Next(100, 252);

    if (hpx < hporiginal)
    {
        if (chance == 2)
        {
            Console.WriteLine("You failed, you did not heal");
            spx -= 10;
            Console.ReadKey();
        }

        else
        {
            if (hpx < hporiginal)
            {
                hpx += value;
                if (hporiginal < hpx) hpx = hporiginal;
                spx -= 20;

                Console.WriteLine();
                Console.Write("You heal ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(value + " HP");
                Console.ResetColor();
                Console.Write("You used ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("20 MP");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    ** ***                              ");
                Console.WriteLine("     ###                                ");
                Console.WriteLine("       ###**                            ");
                Console.WriteLine("      ######                #######     ");
                Console.WriteLine("      #*    #              *##  ###*    ");
                Console.WriteLine("       #    #              ###    ##    ");
                Console.WriteLine("       #  *  **#* ***      *## *##*     ");
                Console.WriteLine("     ##    ##    ## ######    ###       ");
                Console.WriteLine("   *#    *    ***##*   ***#########*    ");
                Console.WriteLine("   ######   #########       #########   ");
                Console.WriteLine("  ############*****##       ###### ##   ");
                Console.WriteLine("   ##################       ###### ##   ");
                Console.WriteLine("   *###############*     *###*  *##*    ");
                Console.WriteLine("                         ###      ###   ");
                Console.WriteLine("                         *##      ##*   ");
                Console.WriteLine();

                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
    else
    {
        Console.WriteLine("You cannot heal, you have maximum HP");
        Console.WriteLine();
        Console.ReadKey();

    }
}

static void invocar(ref int spx, ref int enemyhpx)
{
    Random numgen = new Random();
    int chance = numgen.Next(1, 4);
    int value = numgen.Next(200, 351);

    if (chance == 2)
    {
        Console.WriteLine("You fail to summon lightning");
        spx -= 20;
        Console.ReadKey();
    }

    else
    {
        if (chance == 3)
        {
            Console.WriteLine("You fail to summon lightning");
            spx -= 20;
            Console.ReadKey();
        }

        else
        {
            enemyhpx -= value;
            spx -= 40;

            Console.WriteLine();
            Console.Write("Slime receives ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value + " damage points");
            Console.ResetColor();
            Console.Write("You used ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("40 MP");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  ##############*                      ");
            Console.WriteLine("  #############                        ");
            Console.WriteLine(" ############*                         ");
            Console.WriteLine("  ###########     #         #######    ");
            Console.WriteLine("  ##########      #        *#######*   ");
            Console.WriteLine(" ######### ###   #        ###    ##    ");
            Console.WriteLine("  ##############   *#      *## *##*    ");
            Console.WriteLine("   #############    ######    ###      ");
            Console.WriteLine("    *****######*       ***#########*   ");
            Console.WriteLine("          #####             #########  ");
            Console.WriteLine("          #####             ###### ##  ");
            Console.WriteLine("          ####              ###### ##  ");
            Console.WriteLine("         ####*           *###*  *##*   ");
            Console.WriteLine("    #    ####  #         ###      ###  ");
            Console.WriteLine("     **# ##* *           *##      ##*  ");
            Console.WriteLine();

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

///////////////////////////////////////////////////////////////////////////


/*--FUNCIONS ENEMIC--*/
///////////////////////////////////////////////////////////////////////////

static void atacar_enemic(ref int enemyhpx)
{
    Random numgen = new Random();
    int chance = numgen.Next(1, 15);
    int value = numgen.Next(75, 200);

    if (chance == 2)
    {
        Console.WriteLine("Slime failed the attack");
        Console.ReadKey();
    }

    else
    {
        enemyhpx -= value;

        Console.WriteLine();
        Console.Write("You receive ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(value + " damage points");
        if (value > 150) Console.WriteLine("CRITICAL!");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("      *######################**           //    ");
        Console.WriteLine("      *#                      *      ====//==== ");
        Console.WriteLine("     ####      ##     ##   #######   ===//====  ");
        Console.WriteLine("    ###      ####     ####     **###*  //       ");
        Console.WriteLine("   ###  ##  ## ##     ## ##   #   ###   ");
        Console.WriteLine("   # *  **  ## ##   * ## ##        # #  ");
        Console.WriteLine("   ## ##    #####  #  #####      ##   # ");
        Console.WriteLine("   ##                                 # ");
        Console.WriteLine("   ## **      **********  ***    **   # ");
        Console.WriteLine("  ###       ##*        ##   ###       # ");
        Console.WriteLine("  ##* ##    ###*     #*###* ##*    ##   ");
        Console.WriteLine("   ##        **************     ## ##   ");
        Console.WriteLine("   ###***##**#############******###     ");
        Console.WriteLine();

        Console.ResetColor();
        Console.ReadKey();

    }
}

static void curar_enemic(int hporiginal, ref int hpx)
{
    Random numgen = new Random();
    int chance = numgen.Next(1, 15);
    int value = numgen.Next(120, 252);

    if (hpx < hporiginal)
    {
        if (chance == 2)
        {
            Console.WriteLine("It failed, it could not heal itself");
            Console.ReadKey();
        }

        else
        {
            if (hpx < hporiginal)
            {
                hpx += value;
                if (hporiginal < hpx) hpx = hporiginal;

                Console.WriteLine();
                Console.Write("Slime heals ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(value + " HP");

                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("      *######################**       ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    ||    ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("      *#                      *       ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("====||====");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("     ####      ##     ##   #######    ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("====||====");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("    ###      ####     ####     **###* ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    ||    ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("   ###  ##  ## ##     ## ##   #   ###   ");
                Console.WriteLine("   # *  **  ## ##   * ## ##        # #  ");
                Console.WriteLine("   ## ##     ###   #   ###       ##   # ");
                Console.WriteLine("   ##                                 # ");
                Console.WriteLine("   ## **      **********  ***    **   # ");
                Console.WriteLine("  ###       ##* ////   ##   ###       # ");
                Console.WriteLine("  ##* ##    ###///////#*###* ##*    ##  ");
                Console.WriteLine("   ##        **************     ## ##   ");
                Console.WriteLine("   ###***##**#############******###     ");

                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}

///////////////////////////////////////////////////////////////////////////


/*--ALTRES FUNCIONS--*/
///////////////////////////////////////////////////////////////////////////

static void recap(string playerx, int hporiginal, int sporiginal, int hpenemyoriginal, ref int hpx, ref int spx, ref int enemyhpx, int round)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("*********************************************************");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("TURN " + round);
    Console.ResetColor();
    Console.WriteLine("*********************************************************");
    if (playerx == "Xavi" || playerx == "Judy") Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(playerx + ":");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\tHP: ");
    if (hpx <= (hporiginal/3)) Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(hpx);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("/" + hporiginal);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("\tMP: ");
    Console.WriteLine(spx + "/" + sporiginal);
    Console.ResetColor();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("Slime:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tHP: " + enemyhpx + "/" + hpenemyoriginal);
    Console.ResetColor();
    Console.WriteLine("*********************************************************");
    Console.WriteLine();
    if (round == 1) Console.ReadKey();
}

static void recap_horizontal(string playerx, int hporiginal, int sporiginal, int hpenemyoriginal, ref int hpx, ref int spx, ref int enemyhpx, int round)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("*********************************************************");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("TURN " + round);
    Console.ResetColor();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*                                                       *");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\tSlime:");
    Console.WriteLine("\t\t\t\tHP: " + enemyhpx + "/" + hpenemyoriginal);
    Console.ResetColor();
    Console.WriteLine();


    if (playerx == "Xavi" || playerx == "Judy") Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\t" + playerx + ":");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\tHP: ");
    if (hpx <= (hporiginal / 3)) Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(hpx);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("/" + hporiginal);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("\tMP: ");
    Console.WriteLine(spx + "/" + sporiginal);
    Console.ResetColor();
    Console.WriteLine("*                                                       *");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*******************************");
}

///////////////////////////////////////////////////////////////////////////


/*--PROGRAMA--*/
///////////////////////////////////////////////////////////////////////////


Console.Clear();
Console.Title = "";
Console.WriteLine();
Console.WriteLine("*********************************************************");
Console.WriteLine("*                                                       *");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\t█▄▄▄▄ █ ▄▄    ▄▀         ▄▄▄▄▄   ▄█ █▀▄▀█ ");
Console.WriteLine("\t█  ▄▀ █   █ ▄▀          █     ▀▄ ██ █ █ █ ");
Console.WriteLine("\t█▀▀▌  █▀▀▀  █ ▀▄      ▄  ▀▀▀▀▄   ██ █ ▄ █ ");
Console.WriteLine("\t█  █  █     █   █      ▀▄▄▄▄▀    ▐█ █   █ ");
Console.WriteLine("\t  █    █     ███                  ▐    █ ");
Console.WriteLine("\t ▀      ▀                             ▀   ");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\t\t\t\t\tby Shabii");
Console.ResetColor();
Console.WriteLine("*                                                       *");
Console.WriteLine("*********************************************************");
Console.WriteLine();
Console.Write("\tType your hero's name: ");
Console.ForegroundColor = ConsoleColor.Blue;
string player = Console.ReadLine();
Console.ResetColor();
if (player == "") goto start;
if (player == "Xavi")
{
    Console.WriteLine();
    Console.WriteLine("\t-v-v-v-v Welcome Master v-v-v-v-");
    goto aftername;
}
if (player == "Judy")
{
    Console.WriteLine();
    Console.Write("\t-v-v-v-v Welcome Miss");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" <3");
    Console.ResetColor();
    Console.WriteLine(" v-v-v-v-");
    hp = 9999;
    hporiginal = hp;
    goto aftername;
}
if (player == "God")
{
    Console.WriteLine();
    Console.WriteLine("\t-v-v-v-v Haha, welcome Lord v-v-v-v-");
    enemyhp = 0;
    goto End;
}

Console.WriteLine();
Console.WriteLine("\tIs this the right name?  Yes/No");
name:
Console.Write("\t");
string namedata = Console.ReadLine();
switch (namedata)
{
    case "Y":
        break;

    case "N":
        Console.Clear();
        goto start;

    case "y":
        goto case "Y";

    case "yes":
        goto case "Y";

    case "Yes":
        goto case "Y";

    case "YES":
        goto case "Y";

    case "n":
        goto case "N";

    case "no":
        goto case "N";

    case "No":
        goto case "N";

    case "NO":
        goto case "N";

    default:
        goto name;
}

aftername:
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("\t\t  - PRESS ENTER -");
Console.ReadKey();
Console.Title = "RPG Turn-Based Combat Sim";


preguntar:
recap_horizontal(player, hporiginal, sporiginal, enemyhporiginal, ref hp, ref sp, ref enemyhp, round);
if (hp <= 0) goto End;
if (enemyhp <= 0) goto End;

Console.WriteLine("   Choose your action: ");
Console.WriteLine("*                             *");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("    1.Attack");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("    2.Guard");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("    3.Heal");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("      (20 MP)");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("    4.Summon");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("    (40 MP)");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("    5.Refill MP " + "( " + mppot + "/" + mppotoriginal + " )");
Console.ResetColor();
Console.WriteLine("*                             *");

int guard = 0;

Console.WriteLine("*******************************");
preguntarjugador:
Console.WriteLine("*********************************************************");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(player + "'s action:");
Console.ResetColor();
string data = Console.ReadLine();
Console.WriteLine("*********************************************************");

switch (data)
{
    case "1":
        atacar(ref enemyhp);
        if (enemyhp > 0)
        {
            round++;
            break;
        }
        else break;

    case "2":
        if (enemyhp > 0)
        {
            guard = 1;
            Console.WriteLine();
            Console.WriteLine("You protected yourself");
            Console.Write("You regained ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("10 MP");
            Console.ResetColor();
            sp += 10;
            round++;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     #######        #####       #####   ");
            Console.WriteLine("    *#######*       #########**######   ");
            Console.WriteLine("    ##    ###       #################   ");
            Console.WriteLine("     *##* ##*      *###*#############   ");
            Console.WriteLine("       ###    #######################   ");
            Console.WriteLine("    *#########***   #################   ");
            Console.WriteLine("   #########        ############# ##    ");
            Console.WriteLine("  ## ######         ###########**##     ");
            Console.WriteLine("   ## ######          ######### ###     ");
            Console.WriteLine("    *##*  *###*        *#####**##*      ");
            Console.WriteLine("   ###      ###                         ");
            Console.WriteLine("   *##      ##*                        ");

            Console.WriteLine();

            Console.ResetColor();
            Console.ReadKey();
            break;
        }
        else break;

    case "3":
        int fullcheck = 1;
        if (sp < 20)
        {
            Console.WriteLine("You need more MP");
            Console.ReadKey();
            goto default;
        }
        else
        {
            if (hp != hporiginal)
            {
                curar(hporiginal, ref hp, ref sp);
                round++;
                fullcheck = 0;
            }
        }

        if (enemyhp > 0)
        {
            if (fullcheck == 0) break;
            else
            {
                Console.WriteLine("You cannot heal, you have maximum HP");
                goto preguntarjugador;
            }
        }
        else break;

    case "4":
        if (sp < 40)
        {
            Console.WriteLine("You need more MP");
            Console.ReadKey();
            goto default;
        }
        else
        {
            invocar(ref sp, ref enemyhp);
            round++;
        }

        if (enemyhp > 0)
        {
            break;
        }
        else break;

    case "5":
        if (0 < mppot)
        {
            if (sp < sporiginal)
            {
                int spregen = numgen.Next(40, 80);

                Console.ForegroundColor = ConsoleColor.Cyan;
                sp += spregen;
                if (sp > sporiginal) sp = sporiginal;
                Console.WriteLine(spregen + " MP has been refilled");
                mppot--;


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    ** ***                              ");
                Console.WriteLine("     ###                                ");
                Console.WriteLine("       ###**                            ");
                Console.WriteLine("      ######                #######     ");
                Console.WriteLine("      #*    #              *##  ###*    ");
                Console.WriteLine("       #    #              ###    ##    ");
                Console.WriteLine("       #  *  **#* ***      *## *##*     ");
                Console.WriteLine("     ##    ##    ## ######    ###       ");
                Console.WriteLine("   *#    *    ***##*   ***#########*    ");
                Console.WriteLine("   ######   #########       #########   ");
                Console.WriteLine("  ############*****##       ###### ##   ");
                Console.WriteLine("   ##################       ###### ##   ");
                Console.WriteLine("   *###############*     *###*  *##*    ");
                Console.WriteLine("                         ###      ###   ");
                Console.WriteLine("                         *##      ##*   ");
                Console.WriteLine();

                Console.ResetColor();
                Console.ReadKey();
                break;

            }
            else
            {
                Console.WriteLine("You have all your MP");
                Console.ReadKey();
                goto preguntar;
            }

        }
        else
        {
            Console.WriteLine("You don not have more MP potions remaining");
            goto default;
        }

    case "Attack":
        goto case "1";

    case "Heal":
        goto case "3";

    case "Summon":
        goto case "4";

    case "Refill":
        goto case "5";

    case "Guard":
        goto case "2";

    case "reset":
        goto start;

    case "r":
        goto case "reset";

    default:
        if (enemyhp > 0)
        {
            goto preguntarjugador;
        }
        else break;

}
Console.WriteLine();

Console.WriteLine("*********************************************************");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Slime action:");
Console.ResetColor();

int slimesound = numgen.Next(1, 4);
if (slimesound == 1) Console.WriteLine("\tBUAaah!!");
if (slimesound == 2) Console.WriteLine("\tGRRRraah!");
if (slimesound == 3) Console.WriteLine("\tMuhhhrh!!!");
Console.WriteLine("*********************************************************");

slimecheck:
int slime = numgen.Next(1, 4);
switch (slime)
{
    case 1:
        if (guard == 1)
        {
            int temphp = hp;
            int solidtemphp = hp;
            atacar_enemic(ref hp);
            if (hp == solidtemphp)
            {
                Console.ReadKey();
                goto preguntar;
            }
            else
            {
                temphp -= hp;
                temphp /= 3;
                Console.WriteLine();
                Console.WriteLine("The damage has been lowered,");
                Console.Write("you only receive ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(temphp + " damage points");
                Console.ResetColor();
                solidtemphp -= temphp;
                hp = solidtemphp;
                Console.ReadKey();
                goto preguntar;
            }
        }
        else
        {
            atacar_enemic(ref hp);
            goto preguntar;

        }

    case 2:
        if (curaenemic > 0)
        {
            if (enemyhporiginal == enemyhp) goto slimecheck;
            else
            {
                curar_enemic(enemyhporiginal, ref enemyhp);
                curaenemic--;
                goto preguntar;
            }
        }
        else goto slimecheck;

    case 3:
        goto case 1;
    case 4:
        goto case 1;
}
Console.WriteLine();


End:
if (enemyhp <= 0)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("      ▄   ▄█ ▄█▄      ▄▄▄▄▀ ████▄ █▄▄▄▄ ▀▄    ▄       ▄ ");
    Console.WriteLine("       █  ██ █▀ ▀▄ ▀▀▀ █    █   █ █  ▄▀   █  █       █  ");
    Console.WriteLine("  █     █ ██ █   ▀     █    █   █ █▀▀▌     ▀█       █   ");
    Console.WriteLine("   █    █ ▐█ █▄  ▄▀   █     ▀████ █  █     █        █   ");
    Console.WriteLine("    █  █   ▐ ▀███▀   ▀              █    ▄▀             ");
    Console.WriteLine("     █▐                            ▀                ▀   ");
    Console.WriteLine("     ▐                                                  ");
    Console.ResetColor();
    Console.ReadKey();
}

else
{
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  ██▄   ▄███▄   ▄████  ▄███▄   ██     ▄▄▄▄▀ ");
    Console.WriteLine("  █  █  █▀   ▀  █▀   ▀ █▀   ▀  █ █ ▀▀▀ █     ");
    Console.WriteLine("  █   █ ██▄▄    █▀▀    ██▄▄    █▄▄█    █    ");
    Console.WriteLine("  █  █  █▄   ▄▀ █      █▄   ▄▀ █  █   █     ");
    Console.WriteLine("  ███▀  ▀███▀    █     ▀███▀      █  ▀      ");
    Console.WriteLine("                  ▀              █          ");
    Console.WriteLine("                                ▀           ");
    Console.ResetColor();
    Console.ReadKey();
}

preguntafinal:
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("*********************************************************");
Console.WriteLine();
Console.WriteLine("Do you want to play again?  Yes/No");
string data2 = Console.ReadLine();
switch (data2)
{
    case "Y":
        Console.Clear();
        goto start;

    case "N":
        break;

    case "y":
        goto case "Y";

    case "yes":
        goto case "Y";

    case "Yes":
        goto case "Y";

    case "YES":
        goto case "Y";

    case "n":
        goto case "N";

    case "no":
        goto case "N";

    case "No":
        goto case "N";

    case "NO":
        goto case "N";

    default:
        goto preguntafinal;
}

///////////////////////////////////////////////////////////////////////////