import classes from "./Item.module.css";

function Item({ item }) {
  return (
    <>
      {item.inventoryId != "Flask" && (
        <li className={classes.item}>
          <img src={item.icon} />
        </li>
      )}
    </>
  );
}

export default Item;
