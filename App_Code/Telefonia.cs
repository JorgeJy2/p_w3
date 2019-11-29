
using System.Collections.Generic;

public class Telefonia
{
    private List<SmartphoneBean> smartphones;
    private BDTelefonia bdSmartphones;

    public Telefonia()
    {
        bdSmartphones = BDTelefonia.getInstancia();
        smartphones = bdSmartphones.load();
    }

    public void agregar(SmartphoneBean smartphone)
    {
        bdSmartphones.add(smartphone);
    }

    public SmartphoneBean obtenerIndice(int indice)
    {
        return smartphones[indice];
    }

    public List<SmartphoneBean> obtenerTodo()
    {
        return smartphones;
    }

    public int tamanio()
    {
        return smartphones.Count;
    }

    public void save()
    {
        bdSmartphones = BDTelefonia.getInstancia();
        bdSmartphones.save(smartphones);
    }

    public void add(SmartphoneBean smartphones) {
        bdSmartphones.add(smartphones);
    }

    public bool delete(int position) {
        if (bdSmartphones.delete(smartphones[position].Id)) {
            smartphones.RemoveAt(position);
            return true;
        }
        return false;
    }
}