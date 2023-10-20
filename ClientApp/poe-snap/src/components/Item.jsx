import classes from "./Item.module.css";

function Item({ item }) {
  function renderItem(inventoryId) {
    switch (item.inventoryId) {
      case "Weapon":
        return (
          <div className={classes.weapon}>
            <img src={item.icon} />
          </div>
        );
      case "Helm":
        return (
          <div className={classes.helm}>
            <img src={item.icon} />
          </div>
        );
      case "Offhand":
        return (
          <div className={classes.offhand}>
            <img src={item.icon} />
          </div>
        );
      case "BodyArmour":
        return (
          <div className={classes.bodyArmour}>
            <img src={item.icon} />
          </div>
        );
      case "Ring":
        return (
          <div className={classes.ring}>
            <img src={item.icon} />
          </div>
        );
      case "Ring2":
        return (
          <div className={classes.ring2}>
            <img src={item.icon} />
          </div>
        );
      case "Amulet":
        return (
          <div className={classes.amulet}>
            <img src={item.icon} />
          </div>
        );
      case "Gloves":
        return (
          <div className={classes.gloves}>
            <img src={item.icon} />
          </div>
        );
      case "Boots":
        return (
          <div className={classes.boots}>
            <img src={item.icon} />
          </div>
        );
      case "Belt":
        return (
          <div className={classes.belt}>
            <img src={item.icon} />
          </div>
        );
    }
  }

  return <>{item.inventoryId != "Flask" && renderItem(item.inventoryId)}</>;
}

export default Item;
