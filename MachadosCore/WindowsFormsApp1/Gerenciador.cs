using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MachadosCore
{
    public class Gerenciador<T>
    {
        public   int valor;
       


        public List<T> _itens = new List<T>();
        
        enum Estados
        {
            Adicionado,
            Remover,
            Modificado,
            Acessar,
            Estavel
        }

       


        /// Adiciona o um item a partir  de T ITEM  e muda o estado para Adiocionado 
        public void Adicionar(T item)
        {
            _itens.Add(item);
            
            
            valor = (int)Estados.Adicionado;
        }

        /// Remove  o um item a partir  de T ITEM  e muda o estado para Remover  
        public void Remover(T item)
        {
            _itens.Remove(item);
            valor = (int)Estados.Remover;

        }
        public T GetItemNoIndice(int indice)
        {
            return _itens[indice];
        }

        public int RetornarTamanho()
        {
            return _itens.Count;
        }

        
    }    
 }


