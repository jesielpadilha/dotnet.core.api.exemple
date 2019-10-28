using System;
using System.Collections.Generic;
using Uniciv.Api.Models;

namespace Uniciv.Api.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundoCapital);

        void Alterar(FundoCapital fundoCapital);

        IEnumerable<FundoCapital> Listar();

        FundoCapital ObterPorId(Guid id);

        void Remover(FundoCapital fundo);
    }
}
