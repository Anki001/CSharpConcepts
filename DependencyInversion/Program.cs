// See https://aka.ms/new-console-template for more information

using DependencyInversion;

// Customer operation with File logger
IDatabaseOperationV1 _dbOperations = new DiCustomer(new FileLogger());
_dbOperations.Add();

// Customer operation with Database logger
IDatabaseOperationV1 _dbOperations1 = new DiCustomer(new EmailLogger());
_dbOperations.Add();

