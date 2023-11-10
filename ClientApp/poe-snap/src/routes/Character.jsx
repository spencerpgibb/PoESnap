import { useState } from "react";
import { useLoaderData } from "react-router-dom";

import Item from "../components/Item";
import classes from "./Character.module.css";

function Character() {
  const snapshots = useLoaderData();

  const [firstSnapshotDropdownOpen, setFirstSnapshotDropdownOpen] =
    useState(false);
  const [secondSnapshotDropdownOpen, setSecondSnapshotDropdownOpen] =
    useState(false);

  const [firstSnapshot, setFirstSnapshot] = useState(() => {
    if (snapshots.length > 0) {
      return snapshots[0];
    } else {
      return [];
    }
  });

  const [secondSnapshot, setSecondSnapshot] = useState(() => {
    if (snapshots.length > 0) {
      if (snapshots.length == 1) {
        return [];
      } else if (snapshots.length > 1) {
        return snapshots[1];
      }
    } else {
      return [];
    }
  });

  function handleFirstDropdownOpen() {
    setFirstSnapshotDropdownOpen(!firstSnapshotDropdownOpen);
  }
  function handleSecondDropdownOpen() {
    setSecondSnapshotDropdownOpen(!secondSnapshotDropdownOpen);
  }

  function handleFirstDropdownSelection(e, time) {
    e.preventDefault();
    setFirstSnapshot(snapshots.find((s) => s.snapshotFetchTime == time));
    setFirstSnapshotDropdownOpen(!firstSnapshotDropdownOpen);
  }

  function handleSecondDropdownSelection(e, time) {
    e.preventDefault();
    setSecondSnapshot(snapshots.find((s) => s.snapshotFetchTime == time));
    setSecondSnapshotDropdownOpen(!secondSnapshotDropdownOpen);
  }

  return (
    <>
      <div className={classes.character}>
        <div>
          <button
            type="button"
            onClick={handleFirstDropdownOpen}
            className={classes.dropdown1}
          >
            Select First Snapshot
          </button>
          {firstSnapshotDropdownOpen ? (
            <ul className={classes.menu}>
              {snapshots.length > 0 &&
                snapshots.map((snapshot) => (
                  <li className={classes.menuItem} key={crypto.randomUUID()}>
                    <button
                      type="button"
                      onClick={(e) =>
                        handleFirstDropdownSelection(
                          e,
                          snapshot.snapshotFetchTime
                        )
                      }
                    >
                      {snapshot.snapshotFetchTime}
                    </button>
                  </li>
                ))}
            </ul>
          ) : null}
        </div>
        <div>
          <button
            type="button"
            onClick={handleSecondDropdownOpen}
            className={classes.dropdown2}
          >
            Select Second Snapshot
          </button>
          {secondSnapshotDropdownOpen ? (
            <ul className={classes.menu}>
              {snapshots.length > 0 &&
                snapshots.map((snapshot) => (
                  <li className={classes.menuItem} key={crypto.randomUUID()}>
                    <button
                      type="button"
                      onClick={(e) =>
                        handleSecondDropdownSelection(
                          e,
                          snapshot.snapshotFetchTime
                        )
                      }
                    >
                      {snapshot.snapshotFetchTime}
                    </button>
                  </li>
                ))}
            </ul>
          ) : null}
        </div>
        <div>
          {snapshots.length > 0 && (
            <div className={classes.items1}>
              {firstSnapshot.items.map((item) => (
                <Item key={crypto.randomUUID()} item={item} />
              ))}
            </div>
          )}
        </div>
        <div>
          {snapshots.length > 1 && (
            <div className={classes.items1}>
              {secondSnapshot.items.map((item) => (
                <Item key={crypto.randomUUID()} item={item} />
              ))}
            </div>
          )}
        </div>
      </div>
    </>
  );
}

export default Character;

export async function loader({ params }) {
  const response = await fetch(
    encodeURI("http://localhost:5270/api/character/" + params.characterName)
  );
  const responseData = await response.json();
  return responseData.snapshots;
}
