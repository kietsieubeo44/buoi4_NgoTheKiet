﻿using System;
using System.Text;
class ToaDo
{
    private float x;
    private float y;

    public string Ten { get; set; }

    public ToaDo(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public ToaDo()
    {
        x = 0;
        y = 0;
    }

    public float GetX()
    {
        return x;
    }

    public float GetY()
    {
        return y;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public void SetY(float y)
    {
        this.y = y;
    }

    public override string ToString()
    {
        return Ten + ": (" + GetX() + ", " + GetY() + ")";
    }
}

class HinhTron
{
    private ToaDo tam;
    private double banKinh;

    public HinhTron(ToaDo tam, double banKinh)
    {
        this.tam = tam;
        this.banKinh = banKinh;
    }

    public HinhTron()
    {
        tam = new ToaDo();
        banKinh = 0;
    }

    public ToaDo GetTam()
    {
        return tam;
    }

    public double GetBanKinh()
    {
        return banKinh;
    }

    public void SetTam(ToaDo tam)
    {
        this.tam = tam;
    }

    public void SetBanKinh(double banKinh)
    {
        this.banKinh = banKinh;
    }

    public double TinhChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    public double TinhDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ToaDo tamO = new ToaDo(5.5f, 5.5f)
        {
            Ten = "O"
        };

        HinhTron hinhTron = new HinhTron(tamO, 10.5);

        Console.WriteLine("Hình tròn có tâm " + tamO.ToString() + " với bán kính " + hinhTron.GetBanKinh() + " có diện tích và chu vi lần lượt là " + hinhTron.TinhDienTich().ToString("F3") + " và " + hinhTron.TinhChuVi().ToString("F3") + ".");
        Console.ReadLine();
    }
}
