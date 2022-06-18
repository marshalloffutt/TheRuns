﻿using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IRunService
    {
        List<RunDetails> GetUserRuns(Guid userId);
        RunDetails GetRunDetails(int id);
        RunDetails CreateRun(RunDetails run);
        RunDetails UpdateRun(RunDetails run);
        void DeleteRun(int id);
    }
}