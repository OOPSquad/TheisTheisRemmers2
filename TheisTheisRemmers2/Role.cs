/********************************************************************
*** NAME : Sawyer Theis, Max Theis, Parker Remmers                ***
*** CLASS : CSC 346                                               ***
*** ASSIGNMENT : 2                                                ***
*** DUE DATE : 2-21-2025                                          ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : this program allows for the creation of RPG      ***
*** roles via the Role class, and viewing the roles through the    ***
*** view functions                                                 ***
*********************************************************************/

namespace RoleNS;

using static Global;

public class Role : IView
{
    /********************************************************************
    *** METHOD Role                                                   ***
    *********************************************************************
    *** DESCRIPTION : Constructor for Role class                      ***
    *** INPUT ARGS : string Name, Race Race, Weapon Weapon,           ***
    *** short Health, short Protection                                ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : None                                                 ***
    ********************************************************************/
    public Role(string Name = "Geralt", Race Race = Race.Witcher, short Health = 200, short Protection = 50, Weapon Weapon = Weapon.Axe)
    {
        this.Name = Name;
        this.Race = Race;
        this.Health = Health;
        this.Protection = Protection;
        this.Weapon = Weapon;
    }

    /********************************************************************
    *** METHOD Role                                                   ***
    *********************************************************************
    *** DESCRIPTION : Copy constructor for Role class                 ***
    *** INPUT ARGS : Role role                                        ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : None                                                 ***
    ********************************************************************/
    public Role(Role role)
    {
        Name = role.Name;
        Race = role.Race;
        Health = role.Health;
        Protection = role.Protection;
        Weapon = role.Weapon;
    }

    public string Name { get; set; }
    public Race Race { get; set; }
    public short Health { get; set; }
    public short Protection { get; set; }
    public Weapon Weapon { get; set; }


    /********************************************************************
    *** METHOD ViewH                                                  ***
    *********************************************************************
    *** DESCRIPTION : Displays the role details in horizontal format  ***
    *** INPUT ARGS : None                                             ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    public void ViewH()
    {
        int fixedWidth = 20;
        string header = "Name".PadRight(fixedWidth) +
                    "Race".PadRight(fixedWidth) +
                    "Health".PadRight(fixedWidth) +
                    "Protection".PadRight(fixedWidth) +
                    "Weapon".PadRight(fixedWidth);

        Console.WriteLine(header);
        Console.WriteLine(new string('-', header.Length));

        Console.WriteLine($"{Name}".PadRight(fixedWidth) +
            $"{Race}".PadRight(fixedWidth) +
            $"{Health}".PadRight(fixedWidth) +
            $"{Protection}".PadRight(fixedWidth) +
            $"{Weapon}".PadRight(fixedWidth));
    }

    /********************************************************************
    *** METHOD ViewV                                                  ***
    *********************************************************************
    *** DESCRIPTION : Displays the role details in vertical format    ***
    *** INPUT ARGS : None                                             ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    public void ViewV()
    {
        int fixedWidth = 20;
        Console.WriteLine("Name:".PadRight(fixedWidth) + $"{Name}");
        Console.WriteLine("Race:".PadRight(fixedWidth) + $"{Race}");
        Console.WriteLine("Health:".PadRight(fixedWidth) + $"{Health}");
        Console.WriteLine("Protection:".PadRight(fixedWidth) + $"{Protection}");
        Console.WriteLine("Weapon:".PadRight(fixedWidth) + $"{Weapon}");
    }
}