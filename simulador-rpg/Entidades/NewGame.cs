using System;
using Componentes;
namespace Entidades
{

public class NewGame 
{
    private Menu menu;
    public NewGame()
    {
        Console.WriteLine("Abrir Menu");
        menu = new Menu();
    }
    // public void inicarNovoJogo()
    // {
    //     menu.inciaJogo();
    // }
}
}