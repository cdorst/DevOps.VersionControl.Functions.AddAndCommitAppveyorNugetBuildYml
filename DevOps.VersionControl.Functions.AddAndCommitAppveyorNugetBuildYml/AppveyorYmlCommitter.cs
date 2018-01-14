using DevOps.VersionControl.Structures.GitCommitUser;
using static DevOps.VersionControl.Functions.AddAndCommitGitChanges.GitChangeAdderAndCommitter;
using static Metaproject.Cdn.Containers.Build.Helpers.BuildContentHelper;

namespace DevOps.VersionControl.Functions.AddAndCommitAppveyorNugetBuildYml
{
    public static class AppveyorYmlCommitter
    {
        private const string CommitMessage = "Add appveyor.yml";

        public static void AddAndCommitLicense(string repositoryDirectory, UserInfo? user = null)
        {
            SaveAppveyorYml(repositoryDirectory);
            AddAndCommitChanges(repositoryDirectory, CommitMessage, user);
        }
    }
}
