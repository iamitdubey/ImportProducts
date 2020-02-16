# ImportProducts
Still an initial version application that builds well and tells what the intended design of developing this would be.
Its presumed for now that the type of the import file(.json, .yaml etc) would be an input while executing the exe.
Repository pattern is used to accomodate the migration from MySQL to MongoDB.
Strategy Pattern to differentiate the transforms etc for different import types/transforms.
DI is used to make code testable and reduce coupling
