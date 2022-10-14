using System;
using System.Collections.Generic;

public class Pedido{

    List<ItemPedido> itemPedidos;

    //Construtor para instanciar nova lista
    public Pedido(){
        itemPedidos = new List<ItemPedido>();
    }

    //Método para incluir item no pedido
    public void NovoItem(string produto, double valor, double qt){
        ItemPedido item = new ItemPedido(produto, valor, qt);
        if(item.valorUnitario != 0){
            itemPedidos.Add(item);
        }
    }

    //Método para totalizar o valor do pedido 
    public double TotalValorPedido(){
        double totalValor = 0;
        foreach (var item in itemPedidos){
            double valor = item.quantidade * item.valorUnitario;
            totalValor += valor;
        }
        return totalValor;
    }

    //Método para totalizar a quantidade de itens do pedido 
    public double TotalItensPedido(){
        double totalItens = 0;
        foreach (var item in itemPedidos){
            totalItens += item.quantidade;
        }
        return totalItens;
    }

    //Método para descrever pedido
    public void FinalPedido(){
        foreach (var item in itemPedidos){
            Console.WriteLine(item.quantidade + " " + item.descricao + " de R$" + item.valorUnitario + 
            " reais, totalizando o valor de R$" + item.valorUnitario * item.quantidade + " reais.");
        }
    }

    public List<ItemPedido> ListaPedido(){
        List<ItemPedido> pedido = itemPedidos;
        return pedido;
    }


}