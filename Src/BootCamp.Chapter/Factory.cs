using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract string Brand();

        public DesktopComputer Assemble()
        {
            DesktopComputer PC = new DesktopComputer();
            InstallBody(PC);
            InstallCpu(PC);
            InstallGpu(PC);
            InstallHardDisk(PC);
            InstallMotherboard(PC);
            InstallRam(PC);

            Console.WriteLine($"Finished Building {Brand()}PC. Components List:");
            PC.PrintAssembledPc();

            return PC;
        }

        public abstract void InstallBody(DesktopComputer PC);
        public abstract void InstallCpu(DesktopComputer PC);
        public abstract void InstallGpu(DesktopComputer PC);
        public abstract void InstallHardDisk(DesktopComputer PC);
        public abstract void InstallMotherboard(DesktopComputer PC);
        public abstract void InstallRam(DesktopComputer PC);
        public abstract void PrintAddMsg(string component);
    }
}
