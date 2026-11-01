using System;
using System.Collections.Generic;

interface IInteractable
{
    string Prompt { get; }    // teks yang muncul di layar
    void Interact();
}