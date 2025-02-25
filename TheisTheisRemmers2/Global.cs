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

public static class Global
{
    public enum Race
    {
        DRAGON,
        WITCHER,
        VAMPIRE
    }

    public enum Weapon
    {
        AXE,
        MACE,
        SPELL,
        SWORD
    }
}