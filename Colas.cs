using System;
using System.Collections.Generic;
using System.Text;

public class Colas
{
	public Colas()
    {
        _colas = new List<string>();
    }

    public void Agregar(string dato)
    {
        _colas.Add(dato);
    }

    public void Eliminar()
    {
        if (_colas.Count == 0)
        {
            throw new Exception("La cola está vacía.");
        }
        _colas.RemoveAt(0);
    }

    public string ObtenerDatos()
    {
        StringBuilder datos = new StringBuilder();
        foreach (string dato in _colas)
        {
            datos.AppendLine(dato);
        }
        return datos.ToString();
    }
}
}
