
using System.Collections.Generic;

public class Concesionaria
{
    private List<AutomovilBean> automoviles;
    private BDAutomovil bdAutomovil;

    public Concesionaria()
    {
        bdAutomovil = BDAutomovil.getInstancia();
        automoviles = bdAutomovil.load();
    }

    public void agregar(AutomovilBean smartphone)
    {
        bdAutomovil.add(smartphone);
    }

    public AutomovilBean obtenerIndice(int indice)
    {
        return automoviles[indice];
    }

    public List<AutomovilBean> obtenerTodo()
    {
        return automoviles;
    }

    public int tamanio()
    {
        return automoviles.Count;
    }

    public void save()
    {
        bdAutomovil = BDAutomovil.getInstancia();
        bdAutomovil.save(automoviles);
    }

    public void add(AutomovilBean automovil) {
        bdAutomovil.add(automovil);
    }

    public bool delete(int position) {
        if (bdAutomovil.delete(automoviles[position].Id)) {
            automoviles.RemoveAt(position);
            return true;
        }
        return false;
    }
}