using PolicyManagement.Models;
using PolicyManagement.Repository;

namespace PolicyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PolicyRepository policyRepo = new PolicyRepository();
            List<Policy> policies = policyRepo.GetAllPolicies();

            Console.WriteLine("List of Policies:");
            foreach (var policy in policies)
            {
                Console.WriteLine($"ID: {policy.PolicyId}, Name: {policy.PolicyHolderName}, Type: {policy.PolicyType}, Start Date: {policy.StartDate}, End Date: {policy.EndDate}");
            }
        }
    }

}
