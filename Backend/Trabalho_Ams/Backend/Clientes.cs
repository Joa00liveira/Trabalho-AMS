using System;
using System.Collections.Generic;

namespace Backend
{
    public class Clientes
    {
        private List<Cliente> clientesLista;

        public Clientes()
        {
            clientesLista = new List<Cliente>();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            clientesLista.Add(cliente);
        }

        public Cliente ObterClientePorId(int clienteId)
        {
            return clientesLista.Find(c => c.Id == clienteId);
        }

        public bool EliminarCliente(int clienteId)
        {
            Cliente cliente = ObterClientePorId(clienteId);

            if (cliente != null)
            {
                clientesLista.Remove(cliente);
                return true;
            }

            return false;
        }

        // Add other methods as needed for managing the list of clients

        // Example method to get all clients
        public List<Cliente> ObterTodosClientes()
        {
            return new List<Cliente>(clientesLista);
        }
    }
}