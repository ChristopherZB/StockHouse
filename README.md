Input Forms
===========

Base form is  
```
<FormBase>
    /* Fields to be displayed */ 
</FormBase>
```

## Possible fields

#### Integer field
Syntax  
`<IntField Label="" @bind-Value="" />`  
Where `Label=""` can be any string and represents the fields label and `@bind-Value=""` is a reference to an **integer variable**.

#### String field
Syntax  
`<StringField Label="" @bind-Value="" />`  
Where `Label=""` can be any string and represents the fields label and `@bind-Value=""` is a reference to an **string variable**.


Table
=====
Syntax  
`<Table TableName="" Data="" T="" />`  
Where `TableName=""` can by any string and represents the tables name(will be displayed above table at runtime), `Data=""` is a List<> of the data to be displayed, and `T=""` is the **data type** of `Data`(ex. `List<TestObject> TestList=new List<TestObject>` where `Data="TestList"` and `T="TestObject"`)