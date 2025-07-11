using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() {ID=1, NameMark="Asus", CPU="Amd", CPUFrequency=4200, RAM=8, Hdd=1000, GPUMemory=1, Amount=4, Cost=42300 },
                new Computer() {ID=2, NameMark="Lenovo", CPU="Intel", CPUFrequency=3500, RAM=16, Hdd=1500, GPUMemory=4, Amount=5, Cost=76200 },
                new Computer() {ID=3, NameMark="Msi", CPU="Intel", CPUFrequency=3700, RAM=16, Hdd=750, GPUMemory=2, Amount=25, Cost=53000 },
                new Computer() {ID=4, NameMark="Samsung", CPU="Amd", CPUFrequency=4000, RAM=32, Hdd=2000, GPUMemory=8, Amount=13, Cost=87500 },
                new Computer() {ID=5, NameMark="Apple", CPU="M1", CPUFrequency=2800, RAM=64, Hdd=1000, GPUMemory=12, Amount=64, Cost=97200 },
                new Computer() {ID=6, NameMark="Dexp", CPU="Amd", CPUFrequency=4400, RAM=8, Hdd=500, GPUMemory=4, Amount=83, Cost=93621 },
                new Computer() {ID=7, NameMark="Dell", CPU="Intel", CPUFrequency=5200, RAM=16, Hdd=250, GPUMemory=4, Amount=1, Cost=20720 },
                new Computer() {ID=8, NameMark="Microsoft", CPU="Intel", CPUFrequency=3500, RAM=4, Hdd=2000, GPUMemory=2, Amount=26, Cost=80000 },
                new Computer() {ID=9, NameMark="Honor", CPU="Amd", CPUFrequency=5000, RAM=8, Hdd=1000, GPUMemory=1, Amount=28, Cost=100270 }
            };
            //Все компьютеры с одним процессором 
            Console.WriteLine("Укажите с каким процессором компьютеры вы хотите увидеть (Amd, Intel, M1)");

            string inputcpu = Console.ReadLine();
            while (inputcpu != "Amd" && inputcpu != "Intel" && inputcpu != "M1")
            {
                Console.WriteLine("Введите процессор только из перечисленного списка(Amd, Intel, M1), регистр важен");
                inputcpu = Console.ReadLine();
            }

            List<Computer> compcpu = computers
                .Where(c => c.CPU == inputcpu)
                .ToList();
            foreach (Computer computer in compcpu)
            {
                Console.WriteLine($"Компьютер ID:{computer.ID} {computer.NameMark}, процессор: {computer.CPU}, {computer.CPUFrequency} МГц, ОЗУ {computer.RAM} Гб, storage {computer.Hdd} Гб, GPU {computer.GPUMemory} Гб, {computer.Amount} шт., цена: {computer.Cost}");
            }

            // Компьютеры с ОЗУ не ниже указанного 
            Console.WriteLine("Укажите не ниже какого ОЗУ вывести компьютеры ");
            int inputram = Convert.ToInt32(Console.ReadLine());
            while (inputram < 0)
            {
                Console.WriteLine("Введите положительное число объема ОЗУ");
                inputram = Convert.ToInt32(Console.ReadLine());
            }

            List<Computer> compram = computers
                .Where(c => c.RAM > inputram)
                .ToList();
            foreach (Computer computer in compram)
            {
                Console.WriteLine($"Компьютер ID:{computer.ID} {computer.NameMark}, процессор: {computer.CPU}, {computer.CPUFrequency} МГц, ОЗУ {computer.RAM} Гб, storage {computer.Hdd} Гб, GPU {computer.GPUMemory} Гб, {computer.Amount} шт., цена: {computer.Cost}");
            }

            //весь список, отсортированный по увеличению стоимости;
            Console.WriteLine("Список ПК по увеличению стоимости");

            List<Computer> compincrease = computers
                .OrderBy(c => c.Cost)
                .ToList();
            foreach (Computer computer in compincrease)
            {
                Console.WriteLine($"Компьютер ID:{computer.ID} {computer.NameMark}, процессор: {computer.CPU}, {computer.CPUFrequency} МГц, ОЗУ {computer.RAM} Гб, storage {computer.Hdd} Гб, GPU {computer.GPUMemory} Гб, {computer.Amount} шт., цена: {computer.Cost}");
            }

            // вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Ниже приведен список отсортированный по типу процессора");
            List<Computer> compgrcpu = computers
                .OrderBy(c => c.CPU)
                .ToList();
            foreach (Computer computer in compgrcpu)
            {
                Console.WriteLine($"Компьютер ID:{computer.ID} {computer.NameMark}, процессор: {computer.CPU}, {computer.CPUFrequency} МГц, ОЗУ {computer.RAM} Гб, storage {computer.Hdd} Гб, GPU {computer.GPUMemory} Гб, {computer.Amount} шт., цена: {computer.Cost}");
            }

            //-найти самый дорогой и самый бюджетный компьютер;

            Computer compmaxcost = computers
                .OrderByDescending(c => c.Cost)
                .First();
            Console.WriteLine($"Самый дорогой компьютер ID:{compmaxcost.ID} {compmaxcost.NameMark}, процессор: {compmaxcost.CPU}, {compmaxcost.CPUFrequency} МГц, ОЗУ {compmaxcost.RAM} Гб, storage {compmaxcost.Hdd} Гб, GPU {compmaxcost.GPUMemory} Гб, {compmaxcost.Amount} шт., цена: {compmaxcost.Cost}");

            Computer compmincost = computers
                .OrderBy(c => c.Cost)
                .First();
            Console.WriteLine($"Самый дешевый компьютер ID:{compmincost.ID} {compmincost.NameMark}, процессор: {compmincost.CPU}, {compmincost.CPUFrequency} МГц, ОЗУ {compmincost.RAM} Гб, storage {compmincost.Hdd} Гб, GPU {compmincost.GPUMemory} Гб, {compmincost.Amount} шт., цена: {compmincost.Cost}");

            //-есть ли хотя бы один компьютер в количестве не менее 30 штук ?

            var compgr30 = computers
                 .Any(c => c.Amount >= 30);
            Console.WriteLine($"Eсть ли хотя бы один компьютер в количестве не менее 30 штук - {compgr30}");
        }
    }

    public class Computer
    {
        public int ID { get; set; }
        public string NameMark { get; set; }
        public string CPU { get; set; }
        public int CPUFrequency { get; set; }
        public int RAM { get; set; }
        public int Hdd { get; set; }
        public int GPUMemory { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
    }
}
