using System;
using System.Collections.Generic;

class Door : IInteractable
{
    private bool _isOpen = false;
 
    public string Prompt => _isOpen
        ? "Tekan E untuk menutup pintu"
        : "Tekan E untuk membuka pintu";
 
    public void Interact()
    {
        _isOpen = !_isOpen;
        Console.WriteLine(_isOpen ? "Pintu terbuka." : "Pintu tertutup.");
    }
}