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

public interface IView
{
    /********************************************************************
    *** METHOD ViewH                                                  ***
    *********************************************************************
    *** DESCRIPTION : Displays the role details in horizontal format  ***
    *** INPUT ARGS : None                                             ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    void ViewH();

    /********************************************************************
    *** METHOD ViewV                                                  ***
    *********************************************************************
    *** DESCRIPTION : Displays the role details in vertical format    ***
    *** INPUT ARGS : None                                             ***
    *** OUTPUT ARGS : None                                            ***
    *** IN/OUT ARGS : None                                            ***
    *** RETURN : void                                                 ***
    ********************************************************************/
    void ViewV();
}