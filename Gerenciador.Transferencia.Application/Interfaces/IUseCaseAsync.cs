﻿using Amazon.Runtime.Internal;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.Application.Interfaces
{
    public interface IUseCases<TRequest>
    {
        void Executar(IRequest request);
    }

    public interface IUseCases<TRequest, TResponse>
    {
        TResponse Executar(IRequest request);
    }

    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> Executar(TRequest param);
    }

    public interface IUseCaseAsync<TRequest>
    {
        Task Executar(TRequest param);
    }

    public interface IUseCaseWithoutParamAsync<TResponse>
    {
        Task<TResponse> Executar();
    }
}
