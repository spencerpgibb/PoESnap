import { useLoaderData } from "react-router-dom";

import Item from "../components/Item";
import classes from "./Character.module.css";

function Character() {
  const items = useLoaderData();

  return (
    <>
      {items.length > 0 && (
        <ul className={classes.items}>
          {items.map((item) => (
            <Item item={item} />
          ))}
        </ul>
      )}
      {items.length === 0 && (
        <>
          <div style={{ textAlign: "center", color: "white" }}>
            <h2>Character data is still being fetched...</h2>
          </div>
          <Link to={{}} type="button">
            Reload
          </Link>
        </>
      )}
    </>
  );
}

export default Character;

export async function loader({ params }) {
  const response = await fetch(
    "http://localhost:5270/api/character/" + params.characterName
  );
  const responseData = await response.json();
  return responseData.items;
}