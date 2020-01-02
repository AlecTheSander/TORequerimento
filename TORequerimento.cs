using System;

namespace TORequerimento
{
    public class Requerimento
    {
        /// <summary>
        /// Número de protocolo do Requerimento
        /// </summary>
        String Protocolo { get; set; }
        /// <summary>
        /// Matrícula do aluno que o requerimento se refere.
        /// </summary>
        String Matricula { get; set; }
        /// <summary>
        /// Nome do aluno que o requerimento se refere.
        /// </summary>
        String Nome { get; set; }
        /// <summary>
        /// Data prevista para resposta do requerimento.
        /// </summary>
        String DataResposta { get; set; }
        /// <summary>
        /// Tipo de requerimento.
        /// </summary>
        String Tipo { get; set; }
        /// <summary>
        /// Situação que o requerimento se encontra.
        /// </summary>
        String Situacao { get; set; }
        /// <summary>
        /// Caixa de entrada para qual o requerimento foi enviado.
        /// </summary>
        String Enviado { get; set; }
        /// <summary>
        /// Descrição do requerimento.
        /// </summary>
        String Descricao { get; set; }
    }
}
