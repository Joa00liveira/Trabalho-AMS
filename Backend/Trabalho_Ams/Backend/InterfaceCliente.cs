using System;

namespace Backend
{
    public interface InterfaceCliente
    {
        int AdicionarCliente(Cliente cliente);
        int EliminarCliente(int clienteId);
    }
}
