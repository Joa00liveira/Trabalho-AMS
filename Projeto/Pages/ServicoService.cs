// ServicoService.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Pages
{
    public class ServicoService
    {
        private static readonly List<Servico> _servicos = new List<Servico>();

        public bool PublicarServico(Servico servico)
        {
            try
            {
                // Verificar se o serviço já existe
                if (_servicos.Any(s => s.TipoServico == servico.TipoServico && s.DescricaoServico == servico.DescricaoServico))
                {
                    // Serviço duplicado, retorne false
                    return false;
                }

                // Verificar se a descrição atende a critérios específicos
                if (!DescricaoAtendeCriterios(servico.DescricaoServico))
                {
                    // Descrição não atende aos critérios, retorne false
                    return false;
                }

                // Implemente a lógica de publicação aqui
                _servicos.Add(servico); // Adiciona o serviço à lista (simulação)

                return true; // Indica sucesso
            }
            catch (Exception)
            {
                // Trate exceções, se necessário
                return false; // Indica falha
            }
        }

        private bool DescricaoAtendeCriterios(string descricao)
        {
            // Verificar se a descrição contém palavras-chave específicas
            string[] palavrasChave = { "tempo", "material", "metros quadrados" };
            foreach (var palavra in palavrasChave)
            {
                if (!descricao.Contains(palavra, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            // Adicionar outros critérios, se necessário

            return true;
        }
    }
}
