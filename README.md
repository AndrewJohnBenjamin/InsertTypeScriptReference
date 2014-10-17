InsertTypeScriptReference
=========================


A Visual Studio Extension that allows the user to insert a typescript reference for the highlighted type in the code editor.

What problem does it solve?

Imagine the scenario where you have created a typescript file called `Car.ts` which has a property on it of type `CarEngine`. 
You now need to import the type `CarEngine` for this to be valid typescript.
Importing types is not always straight forward as the types can sometimes live in nested directories, and for a large solution, 
this is a pain. The import syntax is: `import CarEngine = require('../../Engines/CarEngine');`


####`Car.ts`
```typescript

class Car
{
  public Engine : CarEngine;
}

export = Car;
```


With this extension installed you simply need to highlight 'CarEngine' in your Car.ts file, 
and then run Tools->Insert TypeScript Reference. This will locate the type you need to import and insert the correct import 
statement at the top of your file. This command can be mapped to a key combination also.

If the import already exists then no type is added. The extension looks for the first import in your file and inserts the 
reference above that import; if no imports are present, it inserts it at the top of the file.

Note : For this extension to work, it assumes that your types are named the same as your files, as in the example above, class
`Car` resides in file `Car.ts`
