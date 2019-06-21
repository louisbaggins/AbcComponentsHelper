# AbcComponentsHelper
Components of ABC channel
Nuget Package:

https://www.nuget.org/packages/AbcComponentsHelper/

To install the package:

PM> Install-Package AbcComponentsHelper -Version 1.0.0

### This library is implemented for the following Messaging Channels:

- Apple Business Chat

### Using Examples:

PS: Almost all these examples accepts an extra/optional argument that sets the order or style of the element.

PS2: Almost all these examples that uses a collection also accepts to be passed as params[].

## 1. Properties of a listpicker
Channels:
Apple Business Chat

- [BaseMessage](https://developer.apple.com/documentation/businesschatapi/basemessage)
- [InteractiveData: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickermessage/interactivedata)
- [Data : (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickerdata)
- [Sections: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickersection)
- [MultipleSelection](https://developer.apple.com/documentation/businesschatapi/listpickersection)
- [Items(Obligatory)](https://developer.apple.com/documentation/businesschatapi/listpickeritem)
- [Image](https://developer.apple.com/documentation/businesschatapi/imageitem)
- [ReceivedMessage](https://developer.apple.com/documentation/businesschatapi/receivedmessage)
- [ReplyMessage](https://developer.apple.com/documentation/businesschatapi/replymessage)


## 2. Sending a listPicker

Example:

First of all, you'll create a array of items(or pass items as params[])
 ```csharp
 var items = new List<ListPickerItem>();               
 //Defining Items
 items.Add(new ListPickerItem("style", "itemTitle", "imageIdentifier", order, "itemIdentifier"));
 ``` 
 Then you'll create the array of images(if there's any image):
  ```csharp
 var imageArray = new List<Image>();               
 //Defining Items
 imageArray.Add(new Image("ImageIdentifier", Base64Image));
 ``` 
 or 
 
  ```csharp
 imageArray.Add(new Image("ImageIdentifier", byte[] image));
 ``` 
 Then you'll create receveid message item:
 ```csharp
  var receivedMessage = new ReceivedMessage("style", "Title", "Subtitle", "ImageIdentifier");
 ```

Finally, creating listpicker:
```csharp
var sections = new List<Section>();
            sections.Add(new Section(items.ToArray()));
            var listPickerDocument = new ListPickerDocument(
                new InteractiveData(
                    new Data(sections),
                    receivedMessage));
 ```
 
 
 
 Another way of create a listpicker:
 ```csharp
 var items = new List<Items>();
                items.Add(new Items("ItemTitle", "ItemImageIdentifier", "itemImage", order));
                items.Add(new Items("ItemTitle2", "ItemImageIdentifier2", "itemImage2", order+1));
                var listPicker = new ListPickerDocument("ReceveidMessageTitle", "ReceveidMessageSubTitle", items, multipleSelection));
```


## 3. Properties of a TimePicker

- [BaseMessage](https://developer.apple.com/documentation/businesschatapi/baseinteractivemessage)
- [TimePickerInteractiveData: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/timepickermessage/interactivedata)
- [TimePickerData : (Obligatory)](https://developer.apple.com/documentation/businesschatapi/timepickerdata)
- [EventItem: (Obligatory)](https://developer.apple.com/documentation/businesschatapi/eventitem)
- [Location](https://developer.apple.com/documentation/businesschatapi/locationitem)
- [TimeSlots(Obligatory)](https://developer.apple.com/documentation/businesschatapi/timeitem)
- [Image](https://developer.apple.com/documentation/businesschatapi/imageitem)
- [ReceivedMessage](https://developer.apple.com/documentation/businesschatapi/receivedmessage)
- [ReplyMessage](https://developer.apple.com/documentation/businesschatapi/replymessage)

## 4. Sending a Time Picker

You'll have to initialize receivedMessage as you did in listpicker(replyMessage is optional in both cases), but using TimePickerReceivedMessage and TimePickerReplyMessage.

But instead of a collection of items you'll have a collection of TimeSlots, as you can see down bellow:

```csharp
 var timeSlots = new List<TimeSlots>();
                    timeSlots.Add(new TimeSlots(duration,
                        time.ToString($"yyyy-MM-ddTHH:mm{timezonestring}"),
                         timeIdentifier));                
```

Then you can create a TimePicker:

```csharp
var timePickerDocument = new TimePickerDocument(
                new TimePickerInteractiveData(
                    new TimePickerData("1.0",
                    new Event(string.Empty, "Agendamento", timeSlots)),
                    receivedMessage));
```

