using System;
using System.Collections.Generic;
using System.Linq;
using Uniciv.Api.Models;

namespace Uniciv.Api.Repositories
{
    public class FundoCapitalRepository : IFundoCapitalRepository
    {
        private readonly List<FundoCapital> _storage;

        public FundoCapitalRepository()
        {
            _storage = new List<FundoCapital>();
        }

        public void Adicionar(FundoCapital fundoCapital)
        {
            _storage.Add(fundoCapital);
        }

        public void Alterar(FundoCapital fundoCapital)
        {
            var index = _storage.FindIndex(0, 1, x => x.Id == fundoCapital.Id);
            _storage[index] = fundoCapital;
        }

        public IEnumerable<FundoCapital> Listar()
        {
            return _storage;
        }

        public FundoCapital ObterPorId(Guid id)
        {
            return _storage.SingleOrDefault(x => x.Id == id);
        }

        public void Remover(FundoCapital fundoCapital)
        {
            _storage.Remove(fundoCapital);
        }
    }
}
