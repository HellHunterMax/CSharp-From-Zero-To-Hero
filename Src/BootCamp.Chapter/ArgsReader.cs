﻿using BootCamp.Chapter.Exceptions;
using BootCamp.Chapter.ReportsManagers;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        private const string timeCommand = "time";
        private const string cityCommand = "city";
        private const int fileToReadInt = 0;
        private const int commandInt = 1;
        private const int fileToWriteInt = 2;

        public static void Read(string[] args)
        {
            ValidateArgs(args);
            ValidateCommand(args[commandInt]);
            string[] commandArr = ReadCommand(args[commandInt]);
            IReportsManager reportsManager = GetReportManagerExtentionTypeFromCommand(commandArr);

            List<Transaction> transactions = reportsManager.ReadTransactionFile(args[fileToReadInt]);

            ICommand command = default;

            switch (commandArr[0])
            {
                case timeCommand:
                    command = new TimeCommand(args[fileToWriteInt], commandArr, transactions);
                    break;

                case cityCommand:
                    command = new CityCommand(args[fileToWriteInt], commandArr, transactions);
                    break;
            }

            command.Execute();
        }

        private static IReportsManager GetReportManagerExtentionTypeFromCommand(string[] commandArr)
        {
            ReportsManagers.IReportsManager reportsManager;

            string fileType = commandArr[fileToReadInt].Split('.')[1];

            switch (fileType)
            {
                case "json":
                    reportsManager = new ReportsManagers.ReportsManagerJson();
                    break;

                case "xml":
                    reportsManager = new ReportsManagers.ReportsManagerXML();
                    break;

                case "csv":
                    reportsManager = new ReportsManagers.ReportsManagerCSV();
                    break;

                default:
                    throw new FileExtensionUnsupportedException();
            }

            return reportsManager;
        }

        private static void ValidateCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new InvalidCommandException($"Please give a valid command.");
            }
        }

        private static string[] ReadCommand(string command)
        {
            string[] splitCommand = command.Split(' ');

            for (int i = 0; i < splitCommand.Length; i++)
            {
                splitCommand[i] = splitCommand[i].Trim();
            }

            switch (splitCommand[0])
            {
                case timeCommand:
                    return (splitCommand);

                case cityCommand:
                    return (splitCommand);

                default:
                    throw new InvalidCommandException($"{splitCommand[0]} is not a valid command.");
            }
        }

        private static void ValidateArgs(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                throw new InvalidCommandException($"The {nameof(args)} must contain 1. The file path to read. 2. The command. 3. The file path to write.");
            }
        }
    }
}