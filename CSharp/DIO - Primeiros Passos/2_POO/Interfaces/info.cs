// são contratos, ela não implementa, funciona para class e struct
//pode conter métodos, propriedades, eventos e indexadores

//ela tem assinatura do método, ela podem empregar herança mutipla

namespace _2_POO.Interfaces{
    interface IControl{
        void Paint();
    }
    interface IListBox{
        void SetText(string text);
    }
    interface ICoboBox: IListBox, IControl{
        //...
    }
}


