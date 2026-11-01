using System;
using System.Collections.Generic;

class TreasureChest : IInteractable
{
    private bool _isOpened = false;
 
    public string Prompt => _isOpened
        ? "Peti ini sudah kosong"
        : "Tekan E untuk membuka peti harta";
 
    public void Interact()
    {
        if (_isOpened)
        {
            Console.WriteLine("Tidak ada apa-apa lagi di dalam peti.");
            return;
        }
 
        _isOpened = true;
        Console.WriteLine("Peti terbuka! Kamu mendapat 100 emas.");
    }
}