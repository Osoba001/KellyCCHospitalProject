// See https://aka.ms/new-console-template for more information
using Autofac;
using HospitalRepository.HospitalRepository.Wrapper;
using HospitalRepository.NHibernateDatabaseAccess;
using KellyCCBackEndEvaluation2;

var container = new ContainerConfig().Configure();
using (var scop=container.BeginLifetimeScope())
{
    var app = scop.Resolve<IApplication>();
    app.RunDoctors();
    app.RunReceptionist();
    app.RunPharmacist();
    app.RunPatient();
    app.RunAcountant();
}
Console.WriteLine("hello world");
Console.ReadLine();