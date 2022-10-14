using System;
using System.Collections.Generic;

public class ItemPedido{

    public string descricao;
    public double valorUnitario, quantidade;

    public ItemPedido(string produto, double valor, double qt){
        descricao = produto;
        valorUnitario = valor;
        quantidade = qt;
    }
}