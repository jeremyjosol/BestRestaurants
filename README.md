# Best Restaurants

## About
This web application provides users a platform to create and add new cuisines and restaurants. Users can rate their favorite restaurants with an additional search feature that populates queries based on restaurant names. 

Ultimately, Best Restaurants serves as continuing the practice of a fullstack project with strong focus on utilizing the MVC architectural pattern with C# to ensure a well-structured and maintainable codebase while also prioritizing frontend design, creating an intuitive and visually appealing user experience.

![BestRestaurants](https://github.com/jeremyjosol/BestRestaurants/blob/main/BestRestaurants/wwwroot/img/BestRestaurants.jpg?raw=true)

## Technologies Used
* _Github_
* _VSCode_
* _C#_
* _.NET_
* _CSHTML_
* _CSS_
* _JSON_
* _Bootstrap_
* _MySQL Workbench_

## Application Setup

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `BestRestaurants`. 
3. Within the production directory `BestResturants`, create a new file entitled `appsettings.json`.
4. Within `appsettings.json`, enter the following code:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};",
  }
}
```
  > Be sure to replace the `{DATABASE}`, `{USERNAME}` and `{PASSWORD}` fields with your own relevant information. Do not include the curly brackets.
5. In the production directory, you can enter the following command `dotnet watch run`.
  > This command will start the project in development mode with a watcher.

## SQL Designer
![RestaurantSQL](https://github.com/jeremyjosol/BestRestaurants/blob/main/BestRestaurants/wwwroot/img/RestaurantSQL.jpg?raw=true)
_This would be the final schema structure in theory._
_The **Review** class is currently a WIP._